using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CombatStats : MonoBehaviour
{
    public NavMeshAgent unit;
    public Animator anim;
    public LightSwitch buffLight;

    public float HP = 10.0f;
    public float maxHP;
    public int atk = 1;
    public int def = 1;
    public string name = "...";

    private int killcounter;
    public float speed = 0.0f;
    private Vector3 oldPos;

    public VictoryChecker ScoreSystem;
    // Start is called before the first frame update
    void Start()
    {
        maxHP = HP;

        killcounter = 0;

        anim = GetComponentInChildren<Animator>();

        buffLight = GetComponentInChildren<LightSwitch>();
    }

    // Update is called once per frame
    void Update()
    {
        oldPos = transform.position;

        speed = Vector3.Distance(oldPos, transform.position);

        if (HP > maxHP)
        {
            HP = maxHP;
        }

        if (HP <= 0)
        {
            ScoreSystem.deaths++;
            CancelInvoke();
            Debug.Log(name + " has died!");
            Destroy(gameObject);
        }

        if (killcounter < ScoreSystem.kills)
        {
            StopDying();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            anim.SetBool("IsAttacking", true);
            InvokeRepeating("TakeDamage", 1.0f, 2.0f);
        }

        if (other.CompareTag("ShieldTag"))
        {
            Debug.Log("Shield Pickup " + Time.time);
            StartCoroutine(ShieldPickup());
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Healing"))
        {
            HP = HP + 1.0f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        anim.SetBool("IsAttacking", false);
        CancelInvoke("TakeDamage");
    }

    private void TakeDamage()
    {
        int damage = Random.Range(1, 3);
        int finalDamage = damage - def;

        if(finalDamage <= 0)
        {
            finalDamage = 0;
        }

        HP = HP - finalDamage;
        
        if (finalDamage > 0)
        {
            anim.SetTrigger("Ouch");
        }

        Debug.Log(name + " has taken " + finalDamage + " damage!");
    }

    private void StopDying()
    {
        CancelInvoke();
        killcounter = ScoreSystem.kills;
        anim.SetBool("IsAttacking", false);
    }

    IEnumerator ShieldPickup()
    {
        def = def + 3;
        buffLight.switcher = true;

        yield return new WaitForSeconds(10.0f);

        buffLight.switcher = false;
        def = def - 3;
        Debug.Log("Coroutine Ending " + Time.time);
    }
}

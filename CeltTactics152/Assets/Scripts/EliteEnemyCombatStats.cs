using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliteEnemyCombatStats : MonoBehaviour
{
    public Animator anim;

    public float HP = 8.0f;
    public float maxHP;
    public int atk = 0;
    public int def = 2;

    private int killcount;

    public VictoryChecker ScoreSystem;

    // Start is called before the first frame update
    void Start()
    {
        maxHP = HP;
        killcount = 0;

        GetComponent<Light>().enabled = false;

        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HP > maxHP)
        {
            HP = maxHP;
        }

        if (ScoreSystem.done == true)
        {
            Destroy(gameObject);
        }

        if (HP <= 0)
        {
            ScoreSystem.eliteKills++;
            CancelInvoke();
            GetComponent<Light>().enabled = false;
            Destroy(gameObject);
        }

        if (killcount < ScoreSystem.deaths)
        {
            StopDying();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("IsAttacking", true);
            InvokeRepeating("TakeDamage", 1.5f, 2.0f);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Healing"))
        {
            HP = HP + 1.0f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        anim.SetBool("IsAttacking", false);
        CancelInvoke("TakeDamage");
        GetComponent<Light>().enabled = false;
    }

    private void TakeDamage()
    {
        int damage = Random.Range(1, 3);
        int finalDamage = damage - def;

        if (finalDamage <= 0)
        {
            finalDamage = 0;
        }

        GetComponent<Light>().enabled = true;

        if (finalDamage > 0)
        {
            anim.SetTrigger("Ouch");
        }

        HP = HP - finalDamage;

        Debug.Log("Enemy takes " + finalDamage + " damage!");
    }

    private void StopDying()
    {
        anim.SetBool("IsAttacking", false);
        CancelInvoke();
        killcount = ScoreSystem.deaths;
    }
}

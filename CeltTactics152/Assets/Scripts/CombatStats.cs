using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CombatStats : MonoBehaviour
{
    public NavMeshAgent unit;

    public float HP = 10.0f;
    public float maxHP;
    public int atk = 1;
    public int def = 1;
    public string name = "...";

    private int killcounter;

    public VictoryChecker ScoreSystem;
    // Start is called before the first frame update
    void Start()
    {
        maxHP = HP;

        killcounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
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
            InvokeRepeating("TakeDamage", 1.0f, 2.0f);
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

        Debug.Log(name + " has taken " + finalDamage + " damage!");
    }

    private void StopDying()
    {
        CancelInvoke();
        killcounter = ScoreSystem.kills;
    }
}

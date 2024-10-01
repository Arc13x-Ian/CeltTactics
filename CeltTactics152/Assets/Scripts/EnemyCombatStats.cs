using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombatStats : MonoBehaviour
{
    public float HP = 5.0f;
    public float maxHP;
    public int atk = 0;
    public int def = 0;

    private int killcount;

    public VictoryChecker ScoreSystem;

    // Start is called before the first frame update
    void Start()
    {
        maxHP = HP;
        killcount = 0;

        GetComponent<Light>().enabled = false;
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
            ScoreSystem.kills++;
            CancelInvoke();
            GetComponent<Light>().enabled = false;
            Destroy(gameObject);
        }

        if(killcount < ScoreSystem.deaths)
        {
            StopDying();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InvokeRepeating("TakeDamage", 1.0f, 2.0f);
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

        HP = HP - finalDamage;

        Debug.Log("Enemy takes " + finalDamage + " damage!");
    }

    private void StopDying()
    {
        CancelInvoke();
        killcount = ScoreSystem.deaths;
    }
}

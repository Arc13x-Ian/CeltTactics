using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombatStats : MonoBehaviour
{
    public float HP = 5.0f;
    public float maxHP;
    public float atk = 1.0f;
    public float def = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        maxHP = HP;
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
            Destroy(gameObject);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HP = HP - 1.0f;
        }

        if (other.CompareTag("Healing"))
        {
            HP = HP + 1.0f;
        }
    }

    private void Attack()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideObj : MonoBehaviour
{

    public VictoryChecker ScoreSystem;

    public bool hasTriggered = false;

    public GameObject[] reinforcements;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (hasTriggered == false)
        {
            ScoreSystem.sideForts++;

            foreach (GameObject enemy in reinforcements)
            {
                enemy.SetActive(true);
            }

            hasTriggered = true;
        }

    }
}

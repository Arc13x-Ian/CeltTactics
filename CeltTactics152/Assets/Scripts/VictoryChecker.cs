using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryChecker : MonoBehaviour
{

    public int kills;
    public int deaths;
    public int time;
    public int pickups;

    public bool done = false;
    public AudioSource winSound;
    // Start is called before the first frame update
    void Start()
    {
        kills = 0;
        deaths = 0;
        time = 0;
        pickups = 0;
        InvokeRepeating("timetick", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void timetick()
    {
        time = time + 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int pickupscore = pickups * 3;
            int timescore = 120 - time;
            int finalScore = timescore + kills + pickupscore - deaths;
            Debug.Log("You Won!");
            Debug.Log("Time Taken: " + time);
            Debug.Log("Amulets Gathered: " + pickups);
            Debug.Log("Enemies Slain: " + kills);
            Debug.Log("Allies Lost: " + deaths);
            Debug.Log(".....");
            Debug.Log("Final Score: " + finalScore);

            done = true;

            winSound.Play();
        }
    }
}

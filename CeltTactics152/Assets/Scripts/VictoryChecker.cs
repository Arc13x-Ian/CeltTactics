using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryChecker : MonoBehaviour
{

    public int kills;
    public int deaths;
    public int time;

    public bool done = false;
    public AudioSource winSound;
    // Start is called before the first frame update
    void Start()
    {
        kills = 0;
        deaths = 0;
        time = 0;
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
            int timescore = 120 - time;
            int finalScore = timescore + kills - deaths;
            Debug.Log("You Won!");
            Debug.Log("Time Taken: " + time);
            Debug.Log("Enemies Slain: " + kills);
            Debug.Log("Allies Lost: " + deaths);
            Debug.Log(".....");
            Debug.Log("Final Score: " + finalScore);

            done = true;

            winSound.Play();
        }
    }
}

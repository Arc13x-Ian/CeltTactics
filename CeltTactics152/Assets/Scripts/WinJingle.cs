using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinJingle : MonoBehaviour
{
    public AudioSource yay;

    public VictoryChecker ScoreSystem;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreSystem.done == true)
        {
            WinTime();
        }
    }

    void WinTime()
    {
        yay.Play();
        Debug.Log("Jingle");
    }
}

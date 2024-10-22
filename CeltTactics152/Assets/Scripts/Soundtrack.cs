using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrack : MonoBehaviour
{
    public AudioSource audio;

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
            PlayWin();
        }
    }

    void PlayWin()
    {
        audio.Stop();
    }
}

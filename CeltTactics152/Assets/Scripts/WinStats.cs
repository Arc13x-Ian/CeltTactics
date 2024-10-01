using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinStats : MonoBehaviour
{
    public int time;
    public int kills;
    public int deaths;
    public int timescore;
    public int finalscore;

    public VictoryChecker score;

    public Text winnerText;
    public Text timeText;
    public Text killsText;
    public TextMeshPro deathsText;
    public TextMeshPro finalScoreText;

    public GameObject winnerOb;
    public GameObject timeOb;
    public GameObject killsOb;
    public GameObject deathsOb;
    public GameObject finalScoreOb;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(score.done == true)
        {
            WinnerIsYou();
        }
    }

    void WinnerIsYou()
    {
        time = score.time;
        kills = score.kills;
        deaths = score.deaths;

        timescore = 120 - time;
        finalscore = timescore + kills + deaths;

        winnerText.text = "You are Winner!!!";
        timeText.text = "Time Taken: " + time.ToString();
        killsText.text = "Enemies Slain: " + kills.ToString();
        deathsText.text = "Allies Lost: " + deaths.ToString();
        finalScoreText.text = "Final Score Count... " + finalscore.ToString() + "!!!";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("BattleMapTester");
    }

    public void GiveUp()
    {
        Application.Quit();
    }

    public void Surrender()
    {
        SceneManager.LoadScene("LoseScene");
    }
}

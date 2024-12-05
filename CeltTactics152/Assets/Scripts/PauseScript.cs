using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public CharSwitcher CharSwitcher;

    public GameObject unitControl;
    public GameObject pauseMenu;
    public bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("esc hit");

            if (paused == false)
            {
                PauseGame();
                Debug.Log("Pausing");
            }

            else if (paused == true)
            {
                UnPauseGame();
                Debug.Log("Unpausing");
            }
        }
    }

    void PauseGame()
    {
        paused = true;
        unitControl.SetActive(false);
        pauseMenu.SetActive(true);
        CharSwitcher.AllOff();
    }

    public void UnPauseGame()
    {
        paused = false;
        unitControl.SetActive(true);
        pauseMenu.SetActive(false);
    }
}

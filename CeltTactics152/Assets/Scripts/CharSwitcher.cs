using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSwitcher : MonoBehaviour
{

    public CombatStats Hero;
    public CombatStats Two;
    public CombatStats Three;
    public CombatStats Four;
    public CombatStats Five;

    public GameObject[] Units;

    public VictoryChecker ScoreSystem;
    //private Component heroScript;
    //private CharacterMover twoScript;

    // Start is called before the first frame update
    void Start()
    {
        //heroScript = Hero.GetComponent("CharacterMover");
        //twoScript = Two.GetComponent("CharacterMover");
        Units[1].GetComponent<CharacterMover>().enabled = false;
        Units[2].GetComponent<CharacterMover>().enabled = false;
        Units[3].GetComponent<CharacterMover>().enabled = false;
        Units[4].GetComponent<CharacterMover>().enabled = false;

        Units[1].GetComponent<Light>().enabled = false;
        Units[2].GetComponent<Light>().enabled = false;
        Units[3].GetComponent<Light>().enabled = false;
        Units[4].GetComponent<Light>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (ScoreSystem.done == true)
        {
            GameStop();
        }

        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            //heroScript.enabled = true;
            //Hero.GetComponent<CharacterMover>().enabled = true;
            //twoScript.enabled = false;
            //Two.GetComponent<CharacterMover>().enabled = false;

            Debug.Log(Hero.name + " current HP: " + Hero.HP);

            Units[0].GetComponent<CharacterMover>().enabled = true;
            Units[1].GetComponent<CharacterMover>().enabled = false;
            Units[2].GetComponent<CharacterMover>().enabled = false;
            Units[3].GetComponent<CharacterMover>().enabled = false;
            Units[4].GetComponent<CharacterMover>().enabled = false;

            Units[0].GetComponent<Light>().enabled = true;
            Units[1].GetComponent<Light>().enabled = false;
            Units[2].GetComponent<Light>().enabled = false;
            Units[3].GetComponent<Light>().enabled = false;
            Units[4].GetComponent<Light>().enabled = false;
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            //heroScript.enabled = false;
            //twoScript.enabled = true;
            //Hero.GetComponent<CharacterMover>().enabled = false;
            //Two.GetComponent<CharacterMover>().enabled = true;

            Debug.Log(Two.name + " current HP: " + Two.HP);

            Units[0].GetComponent<CharacterMover>().enabled = false;
            Units[1].GetComponent<CharacterMover>().enabled = true;
            Units[2].GetComponent<CharacterMover>().enabled = false;
            Units[3].GetComponent<CharacterMover>().enabled = false;
            Units[4].GetComponent<CharacterMover>().enabled = false;

            Units[0].GetComponent<Light>().enabled = false;
            Units[1].GetComponent<Light>().enabled = true;
            Units[2].GetComponent<Light>().enabled = false;
            Units[3].GetComponent<Light>().enabled = false;
            Units[4].GetComponent<Light>().enabled = false;
        }


        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //heroScript.enabled = false;
            //twoScript.enabled = true;
            //Hero.GetComponent<CharacterMover>().enabled = false;
            //Two.GetComponent<CharacterMover>().enabled = true;

            Debug.Log(Three.name + " current HP: " + Three.HP);

            Units[0].GetComponent<CharacterMover>().enabled = false;
            Units[1].GetComponent<CharacterMover>().enabled = false;
            Units[2].GetComponent<CharacterMover>().enabled = true;
            Units[3].GetComponent<CharacterMover>().enabled = false;
            Units[4].GetComponent<CharacterMover>().enabled = false;

            Units[0].GetComponent<Light>().enabled = false;
            Units[1].GetComponent<Light>().enabled = false;
            Units[2].GetComponent<Light>().enabled = true;
            Units[3].GetComponent<Light>().enabled = false;
            Units[4].GetComponent<Light>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            //heroScript.enabled = false;
            //twoScript.enabled = true;
            //Hero.GetComponent<CharacterMover>().enabled = false;
            //Two.GetComponent<CharacterMover>().enabled = true;

            Debug.Log(Four.name + " current HP: " + Four.HP);

            Units[0].GetComponent<CharacterMover>().enabled = false;
            Units[1].GetComponent<CharacterMover>().enabled = false;
            Units[2].GetComponent<CharacterMover>().enabled = false;
            Units[3].GetComponent<CharacterMover>().enabled = true;
            Units[4].GetComponent<CharacterMover>().enabled = false;

            Units[0].GetComponent<Light>().enabled = false;
            Units[1].GetComponent<Light>().enabled = false;
            Units[2].GetComponent<Light>().enabled = false;
            Units[3].GetComponent<Light>().enabled = true;
            Units[4].GetComponent<Light>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            //heroScript.enabled = false;
            //twoScript.enabled = true;
            //Hero.GetComponent<CharacterMover>().enabled = false;
            //Two.GetComponent<CharacterMover>().enabled = true;

            Debug.Log(Five.name + " current HP: " + Five.HP);

            Units[0].GetComponent<CharacterMover>().enabled = false;
            Units[1].GetComponent<CharacterMover>().enabled = false;
            Units[2].GetComponent<CharacterMover>().enabled = false;
            Units[3].GetComponent<CharacterMover>().enabled = false;
            Units[4].GetComponent<CharacterMover>().enabled = true;

            Units[0].GetComponent<Light>().enabled = false;
            Units[1].GetComponent<Light>().enabled = false;
            Units[2].GetComponent<Light>().enabled = false;
            Units[3].GetComponent<Light>().enabled = false;
            Units[4].GetComponent<Light>().enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            AllOn();
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            AllOff();
        }
    }

    void GameStop()
    {
        Units[0].GetComponent<CharacterMover>().enabled = false;
        Units[1].GetComponent<CharacterMover>().enabled = false;
        Units[2].GetComponent<CharacterMover>().enabled = false;
        Units[3].GetComponent<CharacterMover>().enabled = false;
        Units[4].GetComponent<CharacterMover>().enabled = false;

        Units[0].GetComponent<Light>().enabled = false;
        Units[1].GetComponent<Light>().enabled = false;
        Units[2].GetComponent<Light>().enabled = false;
        Units[3].GetComponent<Light>().enabled = false;
        Units[4].GetComponent<Light>().enabled = false;
    }

    void AllOn()
    {
        Units[0].GetComponent<CharacterMover>().enabled = true;
        Units[1].GetComponent<CharacterMover>().enabled = true;
        Units[2].GetComponent<CharacterMover>().enabled = true;
        Units[3].GetComponent<CharacterMover>().enabled = true;
        Units[4].GetComponent<CharacterMover>().enabled = true;

        Units[0].GetComponent<Light>().enabled = true;
        Units[1].GetComponent<Light>().enabled = true;
        Units[2].GetComponent<Light>().enabled = true;
        Units[3].GetComponent<Light>().enabled = true;
        Units[4].GetComponent<Light>().enabled = true;
    }

    void AllOff()
    {
        Units[0].GetComponent<CharacterMover>().enabled = false;
        Units[1].GetComponent<CharacterMover>().enabled = false;
        Units[2].GetComponent<CharacterMover>().enabled = false;
        Units[3].GetComponent<CharacterMover>().enabled = false;
        Units[4].GetComponent<CharacterMover>().enabled = false;

        Units[0].GetComponent<Light>().enabled = false;
        Units[1].GetComponent<Light>().enabled = false;
        Units[2].GetComponent<Light>().enabled = false;
        Units[3].GetComponent<Light>().enabled = false;
        Units[4].GetComponent<Light>().enabled = false;
    }
}

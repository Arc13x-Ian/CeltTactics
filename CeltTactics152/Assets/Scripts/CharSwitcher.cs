using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSwitcher : MonoBehaviour
{

    public GameObject Hero;
    public GameObject Two;
    public GameObject Three;
    public GameObject Four;
    public GameObject Five;

    public GameObject[] Units;

    //private Component heroScript;
    //private CharacterMover twoScript;

    // Start is called before the first frame update
    void Start()
    {
        //heroScript = Hero.GetComponent("CharacterMover");
        //twoScript = Two.GetComponent("CharacterMover");
        Two.GetComponent<CharacterMover>().enabled = false;
        Units[2].GetComponent<CharacterMover>().enabled = false;
        Units[1].GetComponent<Light>().enabled = false;
        Units[2].GetComponent<Light>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            //heroScript.enabled = true;
            //Hero.GetComponent<CharacterMover>().enabled = true;
            //twoScript.enabled = false;
            //Two.GetComponent<CharacterMover>().enabled = false;

            Units[0].GetComponent<CharacterMover>().enabled = true;
            Units[1].GetComponent<CharacterMover>().enabled = false;
            Units[2].GetComponent<CharacterMover>().enabled = false;

            Units[0].GetComponent<Light>().enabled = true;
            Units[1].GetComponent<Light>().enabled = false;
            Units[2].GetComponent<Light>().enabled = false;
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            //heroScript.enabled = false;
            //twoScript.enabled = true;
            //Hero.GetComponent<CharacterMover>().enabled = false;
            //Two.GetComponent<CharacterMover>().enabled = true;

            Units[0].GetComponent<CharacterMover>().enabled = false;
            Units[1].GetComponent<CharacterMover>().enabled = true;
            Units[2].GetComponent<CharacterMover>().enabled = false;

            Units[0].GetComponent<Light>().enabled = false;
            Units[1].GetComponent<Light>().enabled = true;
            Units[2].GetComponent<Light>().enabled = false;
        }


        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //heroScript.enabled = false;
            //twoScript.enabled = true;
            //Hero.GetComponent<CharacterMover>().enabled = false;
            //Two.GetComponent<CharacterMover>().enabled = true;

            Units[0].GetComponent<CharacterMover>().enabled = false;
            Units[1].GetComponent<CharacterMover>().enabled = false;
            Units[2].GetComponent<CharacterMover>().enabled = true;

            Units[0].GetComponent<Light>().enabled = false;
            Units[1].GetComponent<Light>().enabled = false;
            Units[2].GetComponent<Light>().enabled = true;
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

    void AllOn()
    {
        Units[0].GetComponent<CharacterMover>().enabled = true;
        Units[1].GetComponent<CharacterMover>().enabled = true;
        Units[2].GetComponent<CharacterMover>().enabled = true;

        Units[0].GetComponent<Light>().enabled = true;
        Units[1].GetComponent<Light>().enabled = true;
        Units[2].GetComponent<Light>().enabled = true;
    }

    void AllOff()
    {
        Units[0].GetComponent<CharacterMover>().enabled = false;
        Units[1].GetComponent<CharacterMover>().enabled = false;
        Units[2].GetComponent<CharacterMover>().enabled = false;

        Units[0].GetComponent<Light>().enabled = false;
        Units[1].GetComponent<Light>().enabled = false;
        Units[2].GetComponent<Light>().enabled = false;
    }
}

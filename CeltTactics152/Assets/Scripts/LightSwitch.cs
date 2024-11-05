using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public bool switcher = false;
    public Light lightPart;
    // Start is called before the first frame update
    void Start()
    {
        lightPart = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (switcher == true)
        {
            lightPart.enabled = true;
        }
        else
        {
            lightPart.enabled = false;
        }
    }
}

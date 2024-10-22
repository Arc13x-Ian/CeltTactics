using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPoolScript : MonoBehaviour
{

    public ParticleSystem sparkles;
    // Start is called before the first frame update
    void Start()
    {
        sparkles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        sparkles.Play();
    }
}

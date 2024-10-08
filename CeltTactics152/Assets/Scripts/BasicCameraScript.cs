using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCameraScript : MonoBehaviour
{
    public float spd = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * Time.deltaTime * spd);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * Time.deltaTime * spd);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * spd);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * Time.deltaTime * spd);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * spd);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.down * Time.deltaTime * spd);
        }
    }
}

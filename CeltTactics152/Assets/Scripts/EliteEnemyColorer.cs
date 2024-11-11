using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliteEnemyColorer : MonoBehaviour
{
    SpriteRenderer eliteSprite;
    Color eliteColor;
    // Start is called before the first frame update
    void Start()
    {
        eliteSprite = GetComponent<SpriteRenderer>();
        eliteColor = Color.grey;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

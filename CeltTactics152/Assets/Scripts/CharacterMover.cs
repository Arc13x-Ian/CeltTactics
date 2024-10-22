using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMover : MonoBehaviour
{
    public NavMeshAgent playerNav;
    public Camera gameCam;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray navRay = gameCam.ScreenPointToRay(Input.mousePosition);

            RaycastHit navRayHit;

            if (Physics.Raycast(navRay, out navRayHit))
            {
                playerNav.SetDestination(navRayHit.point);
            }
        }
    }
}

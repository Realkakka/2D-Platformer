using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public CharacterController2D controller;

    float horizontalMove = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Input.GetAxisRaw("Horizontal")

    }
    void FixedUpdate ()
    {
        //move our character
        controller.move(horizontalMove;, false, false);

    }

}

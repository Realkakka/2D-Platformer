using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (inpur.getbuttondown("jump"))
        {
            jump = true;
        }

    }
    void FixedUpdate ()
    {
        //move our character
        controller.move(horizontalMove, false, jump);

    }

}

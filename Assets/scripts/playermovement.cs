using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public controller controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    public Animator anim;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Horizontal"))
        {
            anim.SetFloat("speed", 1);
        }

        if (Input.GetButtonUp("Horizontal"))
        {
            anim.SetFloat("speed", -1);
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;

            anim.SetTrigger("jump");
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, true, jump);
        jump = false;
    }
}
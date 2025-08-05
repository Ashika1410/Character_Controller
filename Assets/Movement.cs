using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator anim;
    CharacterController Controller;
    public float speed = 3f;
    public float rotationspeed = 90;
    public float gravity = 0f;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Keymove();
        moveVelocity.y += gravity * Time.deltaTime;
        Controller.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }
    void Keymove()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetFloat("Blend", 2);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetFloat("Blend", 1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetFloat("Blend", 3);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetFloat("Blend", 1);
        }
    }
}


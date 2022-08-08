using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float Speed = 10;
    public float Walk = 5;
    public Rigidbody rb;
    public bool isGrounded = true;

    void Update(){
        PlayerMovement();
    }

    void PlayerMovement(){
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        

        rb = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
            transform.Translate(playerMovement, Space.Self);
        }
        else
        {
            Vector3 playerMovement = new Vector3(hor, 0f, ver) * Walk * Time.deltaTime;
            transform.Translate(playerMovement, Space.Self);
        }
    }
}

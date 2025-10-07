using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class PlayerMovement: MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;
    public float speed = 10f;
    public float jumpForce = 5f;

    public float mouseSensitivity = 100f;
    private float rotX = 0;
    private float rotY = 0;
   



    private void start() 
    {      
        rb = player.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        transform.Translate(moveHorizontal * Time.deltaTime, 0, 0);
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce * 2, ForceMode.Impulse);
           
        }


    }


}

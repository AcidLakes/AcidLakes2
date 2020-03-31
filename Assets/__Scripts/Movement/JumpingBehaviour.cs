using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class JumpingBehaviour : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 2.0f;
    private Rigidbody rb;
    public BoxCollider col;
    //public bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    /*void OnCollisionStay()
    {
        isGrounded = true;
    }*/

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //isGrounded = false;
        }
    }
}

//https://answers.unity.com/questions/1020197/can-someone-help-me-make-a-simple-jump-script.html
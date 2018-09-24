using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 2f;
    public float maxSpeed = 5f;
    public float jumpPower = 6.5f;

    private Rigidbody rb;
    private bool move = true;
    private bool jump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        if (!move) h = 0;
        rb.AddForce(Vector3.forward * speed * h);
        if (rb.velocity.z > speed)
        {
            rb.velocity = new Vector3(maxSpeed, rb.velocity.y);
        }
        else
        {
            MoveStop();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jump = true;
        }
        if (jump)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * jumpPower, ForceMode.Impulse);
            jump = false;
            
        }
    }
    void MoveStop()
    {
        rb.velocity = new Vector3(0, rb.velocity.y);
    }

    
}

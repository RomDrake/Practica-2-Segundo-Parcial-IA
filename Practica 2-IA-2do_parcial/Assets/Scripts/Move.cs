using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 2f;

    public float maxSpeed = 5f;

    private Rigidbody rb; 
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
    private void FixedUpdate()
    {
        Vector3 fixedVelocity = rb.velocity;
        fixedVelocity.x *= 0.75f;

        float h = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * speed * h);
        float limitedSpeed = Mathf.Clamp(rb.velocity.x, -maxSpeed, maxSpeed);
        rb.velocity = new Vector3(limitedSpeed, rb.velocity.y);

        if(h > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (h < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

    }
}

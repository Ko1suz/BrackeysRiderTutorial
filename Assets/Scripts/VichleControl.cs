using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VichleControl : MonoBehaviour
{
    private Rigidbody2D rb;
    bool move = false;
    bool left;
    bool right;
    private bool isGrounded = false;
    public float speed = 20f;
    public float rotationSpeed = 7f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        if (Input.GetButtonDown("Fire1"))
        {
            move = true;
            left = false;
            right = true;
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            move = true;
            right = false;
            left = true;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            move = false;
        }
        if (Input.GetButtonUp("Fire2"))
        {
            move = false;
        }
    }

    void FixedUpdate()
    {
        if (move == true && right)
        {
            if (isGrounded)
            {
                rb.AddForce(transform.right*speed*Time.fixedDeltaTime*100f,ForceMode2D.Force);
            }
            else
            {
                rb.AddTorque(rotationSpeed*Time.fixedDeltaTime*100f,ForceMode2D.Force);
            }
            
        }
        else if (move == true && left)
        {
            if (isGrounded)
            {
                rb.AddForce(-transform.right*speed*Time.fixedDeltaTime*100f,ForceMode2D.Force);
            }
            else
            {
                rb.AddTorque(-rotationSpeed*Time.fixedDeltaTime*100f,ForceMode2D.Force);
            }
        }
    }
    
    void OnCollisionEnter2D()
    {
        isGrounded = true;
    }

    void OnCollisionExit2D()
    {
        isGrounded = false;
    }
    
}

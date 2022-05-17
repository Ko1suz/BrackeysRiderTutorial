using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontrol : MonoBehaviour
{
    Rigidbody2D rb;
    public int playerSpeed =10; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float hDirection = Input.GetAxis("Horizontal");
        if (/*Input.GetKey(KeyCode.A)*/ hDirection < 0)
        {
            rb.velocity = new Vector2(-playerSpeed, rb.velocity.y);
            transform.localScale = new Vector2(-1, 1);
            // state = State.running;
            // transform.localScale = new Vector3(-1,1,this.gameObject.transform.position.z+2);
            //transform.position = new Vector3(player.position.x,player.position.y,transform.position.z-10);
            // GetComponent<Animator>();
            // anim.SetBool("Run",true);
        }
        else if (/*Input.GetKey(KeyCode.D)*/ hDirection > 0)
        {
            rb.velocity = new Vector2(playerSpeed * 1, rb.velocity.y);
            transform.localScale = new Vector2(1, 1);
            // state = State.running;
            // transform.localScale = new Vector3(1,1,this.gameObject.transform.position.z+2);
            // anim.SetBool("Run",true);

        }
    }
}

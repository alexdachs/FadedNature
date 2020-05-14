using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{



    
    public float JumpForce = 1f;
    private Rigidbody2D rigidBody2D;
    public bool PuedoSaltar = false;



    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Jump()
    {
        rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, JumpForce);
        PuedoSaltar = false;
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            PuedoSaltar = true;
        }


    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && PuedoSaltar == true)
        {
            Jump();
        }
        


    }

}

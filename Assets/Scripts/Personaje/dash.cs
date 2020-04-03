using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dash : MonoBehaviour
{

    public float force = 40000f;


    public Rigidbody2D rigidBody2D;




    // Use this for initialization
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Dash();


        void Dash()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey("a"))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-force, 0), ForceMode2D.Force);





            }
            else if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey("d"))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0), ForceMode2D.Force);


            }

        }


    }
}



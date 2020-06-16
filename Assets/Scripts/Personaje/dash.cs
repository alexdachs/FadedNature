using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dash : MonoBehaviour
{

    public float force = 40000f;


    public Rigidbody2D rigidBody2D;

    private float AttackTimer;
    public float Seconds;


    // Use this for initialization
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        AttackTimer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            if (AttackTimer <= 0)
            {
                  GetComponent<Rigidbody2D>().AddForce(new Vector2(-force, 0), ForceMode2D.Force);
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            if (AttackTimer <= 0)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0), ForceMode2D.Force);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey(KeyCode.LeftArrow))
        {
            if (AttackTimer <= 0)
            {
                  GetComponent<Rigidbody2D>().AddForce(new Vector2(-force, 0), ForceMode2D.Force);
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey(KeyCode.RightArrow))
        {
            if (AttackTimer <= 0)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0), ForceMode2D.Force);
            }
        }


    }


    
       
      
    

    
      
    











  

    
}



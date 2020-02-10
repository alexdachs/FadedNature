using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{

    public Rigidbody2D rigidBody2D;
    public float MaxSpeed = 15f;
    


    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            float Xdireccion = Input.GetAxis("Horizontal");
            rigidBody2D.velocity = new Vector2(Xdireccion * MaxSpeed, rigidBody2D.velocity.y);


        }

    }
}

    


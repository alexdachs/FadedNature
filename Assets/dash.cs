using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{

    public Rigidbody2D rigidBody2D;
    public float speed, delay, delayPress;
    public bool startDelay;
    public int rigthPress, leftPress;
    public float timePassed, timePassedPress;
    public bool startTimer;



    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        rigthPress = 0;
        leftPress = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            leftPress++;
            startTimer = true;


        }
        else if (Input.GetButtonDown("right"))
        {
            rigthPress++;
            startTimer = true;
        }

        if (startTimer)
        {
            timePassedPress += Time.deltaTime;
            if (timePassedPress >= delayPress)
            {
                startTimer = false;
                leftPress = 0;
                rigthPress = 0;
            }
        }
        if (leftPress >= 2 || rigthPress >= 2)
        {
            startDelay = true;

        }

    }
    void FixedUpdate()
    {
        if (startDelay)
        {
            timePassed += Time.fixedDeltaTime;
            if (timePassed <= delay)
            {
                if (rigthPress >= 2)
                {
                    rigidBody2D.velocity = new Vector2(speed, rigidBody2D.velocity.y);
                    rigthPress = 0;
                }
                else if (leftPress >= 2)
                {
                    rigidBody2D.velocity = new Vector2(-speed, rigidBody2D.velocity.y);
                      
                    else 
                    {
                        timePassed = 0;
                        startDelay = false;
                        rigthPress = 0;
                        leftPress = 0;
                    }
                }
            }
        }
    }
}
    


    


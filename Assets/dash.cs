using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{

    public float dash = 3000f;
    public bool CanIDash = true;
    public float time = 5.0f;

    // Use this for initialization
    void Start()
    {
       
    }
    void Dashear()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(dash, 0), ForceMode2D.Force);
        CanIDash = false;
        time = 0.0f;
        if (time == 5.0f)
        {
            CanIDash = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && CanIDash == true)
        {
            Dashear();
          
        }
    }
   
}



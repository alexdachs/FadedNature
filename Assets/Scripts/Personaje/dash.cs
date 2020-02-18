using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{

    public float force = 3000f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        {
            if (Input.GetButtonDown("Fire1") && Input.GetKey("a"))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-force, 0), ForceMode2D.Force);

            }
            else if (Input.GetButtonDown("Fire1") && Input.GetKey("d"))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0), ForceMode2D.Force);

            }
        }
    }
}



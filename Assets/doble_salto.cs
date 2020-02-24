using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doble_salto : MonoBehaviour
{




    public float JumpForce = 17f;
    private Rigidbody2D rigidBody2D;
    public bool PuedoSaltar = false;
    public int salto = 2;
    public bool desbloqueado = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

    }

    void Jump()
    {
        
        
            rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, JumpForce);
            salto--;

        
        if (salto ==0)
        {
            PuedoSaltar = false;
            salto = 2;
        }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "Hola")
        {
            PuedoSaltar = true;
            desbloqueado = true;
            Destroy(collision.gameObject);
        }
         if  (collision.gameObject.tag == "suelo")
            {
                PuedoSaltar = true;
                salto = 2;
            }


    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) &&(PuedoSaltar == true) && (desbloqueado ==true))
        {
            Jump();
        }





    }

   

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ataque : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;


    public float bulletForce;
    public GameObject bullet;
    public bool ataqueDerecha = false;
    public bool ataqueIzquierda = false;

    private float AttackTimer;
    public float Seconds;







    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    {
        AttackTimer -= Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.A))
        {
            ataqueDerecha = false;
            ataqueIzquierda = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ataqueDerecha = true;
            ataqueIzquierda = false;
        }
        if (Input.GetButtonDown("Fire1") && ataqueIzquierda == true)
        {

            if (AttackTimer <= 0)
            {
                GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.left * bulletForce);
                Destroy(newBullet, 5.0f);
                AttackTimer = Seconds;
            }


        }

        if (Input.GetButtonDown("Fire1") && ataqueDerecha == true)
        {
            if (AttackTimer <= 0)
            {


                GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right * bulletForce);
                Destroy(newBullet, 5.0f);
                AttackTimer = Seconds;
            }
        }


    }

  





}
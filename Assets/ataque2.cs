﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ataque2 : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public int tiempoDisparo = 1;

    public float bulletForce;
    public GameObject bullet;
    public bool ataqueDerecha = false;
    public bool ataqueIzquierda = false;

    public bool puedoDisparar = true;







    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    {



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
            if (puedoDisparar == true)
            {
                StartCoroutine(Esperar());
            }


        }

        if (Input.GetButtonDown("Fire1") && ataqueDerecha == true)
        {
       
            StartCoroutine(Esperar2());

        }


    }

    IEnumerator Esperar()
    {

        GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.left * bulletForce);
        Destroy(newBullet, 5.0f);


        puedoDisparar = false;
        yield return new WaitForSeconds(tiempoDisparo);
        puedoDisparar = true;



    }

    IEnumerator Esperar2()
    {
        yield return new WaitForSeconds(1);
        GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right * bulletForce);
        Destroy(newBullet, 5.0f);

    }


    
    
    
    





}
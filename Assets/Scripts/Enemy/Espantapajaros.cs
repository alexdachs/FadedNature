﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Espantapajaros : MonoBehaviour
{
    public int CurrentHealth = 50;
    public int dmg;

    public static float MaxHealth;

    Rigidbody2D rb;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = 50;
        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }

    }
    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            MaxHealth -= 0.1f;

        }
        if (collision.gameObject.tag == "Attack")
        {

            CurrentHealth = CurrentHealth - 25;

        }
    }


}

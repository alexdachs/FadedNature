using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostSoul : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 direction;
    public float speed;


    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("MainChar").transform;

    }

    void Update()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = (player.position - transform.position).normalized;
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);

    }



}


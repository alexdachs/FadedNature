using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private float velocity = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        //rigidBody.velocity = transform.up*100;
    }
    private void FixedUpdate()
    {
        float delta = Time.fixedDeltaTime * 100;
        rigidBody.velocity = transform.right * 30;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "escenario")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Bat")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Calabacin")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "LostSoul")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Boss")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 2);
    }
}

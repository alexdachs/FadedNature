using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostSoul : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 direction;
    public float speed;
    int hp;

    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("MainChar").transform;
        hp = 100;
    }

    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = (player.position - transform.position).normalized;
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Attack")
        {
            hp = hp - 30;
        }
    }

    public void TakeDamage(int _damage)
    {
        hp -= _damage;
    }

}


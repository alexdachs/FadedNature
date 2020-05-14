using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Calabacinos : MonoBehaviour
{

    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform[] ArrayPos;
    private int Spot;

    public int Health = 100;

    public Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        Spot = Random.Range(0, ArrayPos.Length);
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, ArrayPos[Spot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, ArrayPos[Spot].position) < 7f)
        {
            if (waitTime <= 0)
            {
                Spot = Random.Range(0, ArrayPos.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        if(Health <= 0)
        {
            Destroy(gameObject);
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Attack"))
        {
            Destroy(collision.gameObject);
            Health = Health - 50;
        }
    }


    public void TakeDamage(int _damage)
    {
        Health -= _damage;
    }

}
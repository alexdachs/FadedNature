using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightAttack : MonoBehaviour
{
    private float attackTimer;
    public float seconds;
    public int damage;
    public float timeAttack;
   
    [SerializeField] Collider2D micollider2d;
   
   

    // Update is called once per frame
    void Update()
    {
        attackTimer -= Time.deltaTime;

        if (attackTimer <= 0)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                micollider2d.enabled = true;

                attackTimer = seconds;
                Invoke("DisableAttack", timeAttack);
                
            }


        }
    }
    void DisableAttack()
    {
        micollider2d.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.tag == "Bat")
        {
            collision.GetComponent<Patrulla>().TakeDamage(damage);
        }
        if (collision.gameObject.tag == "LostSoul")
        {
            collision.GetComponent<LostSoul>().TakeDamage(damage);
        }
        if (collision.gameObject.tag == "Calabacin")
        {
            collision.GetComponent<Calabacinos>().TakeDamage(damage);
        }
        if (collision.gameObject.tag == "Boss")
        {
            //collision.GetComponent<Tree_boss>().TakeDamage(damage);
        }
    }
    

}


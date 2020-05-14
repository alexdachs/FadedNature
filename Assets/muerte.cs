using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerte : MonoBehaviour
{
    private int initHP = 100;
    public int HP;
    // Start is called before the first frame update
    void Start()
    {
        HP = initHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Attack"))
        {
            Destroy(collision.gameObject);

            HP = HP - 50;
            


        }
    }
}

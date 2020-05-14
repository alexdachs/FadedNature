using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    public GameObject portal;
    public int HP;
    private int initHP = 500;

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
            portal.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Attack"))
        {

            Destroy(collision.gameObject);

        }
    }
}

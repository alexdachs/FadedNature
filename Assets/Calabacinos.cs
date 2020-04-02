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

    public int Health;

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


    }
    private void OnTriggerEnter2D(Collider2D laser)
    {
        if (laser.CompareTag("Attack"))
        {
            Destroy(laser.gameObject);
            Health = Health - 1;
        }

    }

}
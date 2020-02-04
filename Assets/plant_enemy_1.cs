using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_enemy_1 : MonoBehaviour
{
    
    //HP
    private int iniHp = 100;
    public int hp;
    //ATK
    private int AttackDmg;
    //SPEED
    public float speed;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        //INIT ENEMY
        AttackDmg = 25;
        hp = iniHp;
        //GET PLAYER
        target = GameObject.FindGameObjectWithTag("MainChar").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //FOLLOW PLAYER
        if (Vector2.Distance(transform.position, target.position) > 1 && Vector2.Distance(transform.position, target.position) < 8)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        if (Vector2.Distance(transform.position, target.position) > 2)
        {
            //ATTACK
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ////(Recibe Ataque jugador)
        //if (collision.gameObject.tag == "")
        //{
        //    hp -= 10;
        //}
    }
    
}

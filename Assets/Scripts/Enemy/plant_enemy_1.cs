﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_enemy_1 : MonoBehaviour
{
    
    //HP
    private int iniHp = 100;
    public int hp;
    //ATK
    public GameObject leaf;
    static float delay = 2f;
    private float attackTimer = delay;
    bool isAttack = false;
    //SPEED
    public float speed;
    private Transform target;
    public GameObject potion;

    // Start is called before the first frame update
    void Start()
    {
        //INIT ENEMY        
        hp = iniHp;
        //GET PLAYER
        target = GameObject.FindGameObjectWithTag("MainChar").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //FOLLOW PLAYER
        if (Vector2.Distance(transform.position, target.position) > 1 && Vector2.Distance(transform.position, target.position) < 8 && isAttack == false)
        {
            if(Vector2.Distance(new Vector2(0,transform.position.y), new Vector2(0,target.position.y)) <= 0.5f)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            
        }
        //ATTACK
       
        
        if(attackTimer > 0)
        {
            attackTimer -= Time.deltaTime;
        }
        if (Vector2.Distance(transform.position, target.position) < 6 && Vector2.Distance(new Vector2(0, transform.position.y), new Vector2(0, target.position.y)) < 1f && attackTimer <= 0)
        {
            isAttack = true;
            if (target.position.x > transform.position.x)
            {
                
                GameObject leafAttk = Instantiate(leaf, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.identity);
                leafAttk.GetComponent<Rigidbody2D>().AddForce(transform.right * 5000);
                attackTimer = delay;
            }
           if (target.position.x < transform.position.x)
            {
                GameObject leafAttk = Instantiate(leaf, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), Quaternion.identity);
                leafAttk.GetComponent<Rigidbody2D>().AddForce(transform.right * -5000);
                attackTimer = delay;
            }


        }
        
        //DIE
        if(hp <= 0)
        {
            Destroy(gameObject);
            float rand = Random.Range(0.0f, 1.0f);
            if (rand < 0.5)
            {
                Instantiate(potion, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            }
            else
            {

            }
        }
    }
    
    public void TakeDamage(int _damage)
    {
        hp -= _damage;
    }
    
}

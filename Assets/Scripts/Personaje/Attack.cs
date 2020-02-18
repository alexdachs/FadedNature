using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private float attackTimer;
    public float seconds;

    public Transform attackPosRight;
    public Transform attackPosLeft;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(attackTimer <= 0)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPosRight.position,attackRange,whatIsEnemies);
                for(int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<plant_enemy_1>().TakeDamage(damage);
                }
            }
            if (Input.GetKey(KeyCode.Q))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPosLeft.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<plant_enemy_1>().TakeDamage(damage);
                }
            }
            attackTimer = seconds;
        }
        else
        {
            attackTimer -= Time.deltaTime;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPosLeft.position, attackRange);
        Gizmos.DrawWireSphere(attackPosRight.position, attackRange);
    }
}

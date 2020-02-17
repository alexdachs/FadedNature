using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xp_hp : MonoBehaviour
{
    //UI
    public Text PlayerHp;
    public Text PlayerXp;
    public Text PlayerLvl;
    //HP
    private int iniHp = 100;
    public int hp;
    //XP
    public float xp;
    //LVL
    private int startLvl = 1;
    public int lvl;
    //ATK
    public int AttackDmg;
    
   



    // Start is called before the first frame update
    void Start()
    {
        
        //INIT PLAYER STATS
        AttackDmg = 25;
        hp = iniHp;
        lvl = startLvl;
        xp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        //DIE
        if (hp <= 0)
        {
            //TO DO: RESPAWN MENU
            xp = 0;
            Destroy(gameObject);
        }
        //LVL UP
        if (xp >= 100)
        {
            xp -= 100;
            lvl += 1;
        }
        //SHOW IN SCREEN
        PlayerHp.GetComponent<Text>().text = hp.ToString();
        PlayerXp.GetComponent<Text>().text = xp.ToString();
        PlayerLvl.GetComponent<Text>().text = lvl.ToString();
    }

   

    //COLLISIONS
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        //COLLISION WITH ENEMYS

        if (collision.gameObject.tag == "BasicEnemyCol")
        {
            hp = hp -5;
        }
        if (collision.gameObject.tag == "leave_atk")
        {
            hp = hp - 15;
        }
        if (collision.gameObject.tag == "MediumEnemyCol")
        {
            hp = hp-10;
        }
        if (collision.gameObject.tag == "HardEnemyCol")
        {
            hp = hp-15;
        }
    }
}

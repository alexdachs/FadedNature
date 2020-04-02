using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xp_hp : MonoBehaviour
{
    //UI
    public Scrollbar PlayerHp;
   // public Text PlayerXp;
   // public Text PlayerLvl;
    //HP
    private int iniHp = 100;
    public int hp;
    //XP
    public float xp;
    //LVL
    private int startLvl = 1;
    public int lvl;
    
    
   



    // Start is called before the first frame update
    void Start()
    {
        
        //INIT PLAYER STATS
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
       PlayerHp.size = hp/100f;
       // PlayerXp.GetComponent<Text>().text = xp.ToString();
       // PlayerLvl.GetComponent<Text>().text = lvl.ToString();
    }

   

    //COLLISIONS
    private void OnCollisionEnter2D(Collision2D collision)
    {

        //COLLISION WITH ENEMYS

        if (collision.gameObject.tag == "Calabacin")
        {
            hp = hp - 2;
        }
        if (collision.gameObject.tag == "Bat")
        {
            hp = hp - 2;
        }
        if (collision.gameObject.tag == "LostSoul")
        {
            hp = hp - 5;
        }

        if (collision.gameObject.tag == "leave_atk")
        {
            hp = hp - 15;
        }
        if (collision.gameObject.tag == "Potion")
        {
            hp = hp + 10;
            Destroy(collision.gameObject);
        }

    }

    public void TakeDamage(int _damage)
    {
        hp -= _damage;
    }
}

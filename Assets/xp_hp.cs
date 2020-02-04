using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xp_hp : MonoBehaviour
{
    public Text PlayerHp;
    public Text PlayerXp;
    public Text PlayerLvl;
    private int iniHp = 100;
    public int hp;
    public float xp;
    private int startLvl = 1;
    public int lvl;
    Rigidbody2D myRb2D;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        myRb2D.GetComponent<Rigidbody2D>();
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
            
            xp = 0;
            Destroy(gameObject);
        }
        //LVL UP
        if (xp >= 100)
        {
            xp -= 100;
            lvl += 1;
        }
        PlayerHp.GetComponent<Text>().text = hp.ToString();
        PlayerXp.GetComponent<Text>().text = xp.ToString();
        PlayerLvl.GetComponent<Text>().text = lvl.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //COLLISION WITH ENEMYS
        
        if (collision.gameObject.tag == "BasicEnemy")
        {
            
            xp -= 10;
        }
        if (collision.gameObject.tag == "MediumEnemy")
        {
            xp -= 15;
        }
        if (collision.gameObject.tag == "HardEnemy")
        {
            xp -= 20;
        }
    }
}

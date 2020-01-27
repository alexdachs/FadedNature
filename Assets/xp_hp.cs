using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xp_hp : MonoBehaviour
{
    public GameObject PlayerHp;
    public GameObject PlayerXp;
    public int hp;
    public float xp;
    public int lvl;
    private Rigidbody2D rb;
    
    void initPlayer()
    {
        hp = 100;
        xp = 0;
        lvl = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        initPlayer();

    }

    // Update is called once per frame
    void Update()
    {       
        GameObject UiHp = PlayerHp;
        int HpActual = hp;
        /*colision
        if ()
        {
            restar vida
        }*/

        if (hp <= 0 )
        {
            //MORIR
        }
        if (xp >= 100)
        {
            xp -= 100;
            lvl += 1;
        }
        UiHp.GetComponent<Text>().text = HpActual.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xp_hp : MonoBehaviour
{
    public float hp;
    public float xp;
    public int lvl;
    public GameObject PlayerHp;
    public GameObject PlayerXp;
    

    void initPlayer()
    {
        hp = 100.0f;
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
        GameObject hpText = PlayerHp;
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
        hpText.GetComponent<Text>().text = hp.ToString;
    }
}

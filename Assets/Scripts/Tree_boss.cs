using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tree_boss : MonoBehaviour
{
    //HP
    private int hp;
    //MELE
    private bool melee = false;
    private float meleAttackTimer;
    public float meleSeconds;
    public int damage;
    public float meleTimeAttack;
    [SerializeField] Collider2D micollider2d;
    private Transform target;
    //POISON BUBLES
    public Transform[] aparicionVertical;
    public Transform[] aparicionHorizontal;
    private int random;
    public GameObject buble;

    private float bubleAttackTimer;
    public float bubleSeconds;



    // Start is called before the first frame update
    void Start()
    {
        //GET PLAYER
        target = GameObject.FindGameObjectWithTag("MainChar").GetComponent<Transform>();
        //HP
        hp = 500;
        meleAttackTimer = meleSeconds;
        bubleAttackTimer = bubleSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        //DIE
        if (hp <= 0)
        {
           Destroy(gameObject);
            SceneManager.LoadScene("ToBeContinued");
        }
        //MELE
        if(Vector2.Distance(transform.position,target.transform.position) < 3)
        {
            meleAttackTimer -= Time.deltaTime;
            bubleAttackTimer = bubleSeconds;

            if (meleAttackTimer <= 0)
            {
                melee = true;

                 micollider2d.enabled = true;

                 meleAttackTimer = meleSeconds;
                 Invoke("DisableAttack", meleTimeAttack);
            }          
        }
        else if (Vector2.Distance(transform.position, target.transform.position) > 6)
        {
            meleAttackTimer = meleSeconds;
        }
        bubleAttackTimer -= Time.deltaTime;
        //BUBLE POISON
        if(melee == false && bubleAttackTimer <= 0)
        {
            random = Random.Range(0,2);
            Debug.Log(random);
            if(random == 1)
            {
                for (int i = 0; i < aparicionHorizontal.Length; i++)
                {
                    GameObject poisonBuble = Instantiate(buble, aparicionHorizontal[i].transform.position, Quaternion.identity);
                    poisonBuble.GetComponent<Rigidbody2D>().AddForce(transform.right * -5000);
                    bubleAttackTimer = bubleSeconds;
                }
            }
            else if (random == 0)
            {
                for (int i = 0; i < aparicionVertical.Length; i++)
                {
                    GameObject poisonBuble = Instantiate(buble, aparicionVertical[i].transform.position, Quaternion.identity);
                    poisonBuble.GetComponent<Rigidbody2D>().AddForce(transform.up * -5000);
                    bubleAttackTimer = bubleSeconds;
                }
            }
        }
    }

    void DisableAttack()
    {
        micollider2d.enabled = false;
        melee = false;
    }

    public void TakeDamage(int _damage)
    {
        hp -= _damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MainChar")
        {
            collision.GetComponent<xp_hp>().TakeDamage(damage);
        }
        if (collision.gameObject.tag == "Attack")
        {
            hp = hp - 100;
        }
    }
}

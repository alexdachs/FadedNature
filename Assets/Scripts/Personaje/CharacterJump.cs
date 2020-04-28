using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public Animator animator;
    public float JumpForce = 1f;
    private Rigidbody2D body;
    SpriteRenderer sprite;
    public bool PuedoSaltar = false;
    bool TocandoSuelo;

    [SerializeField]
    Transform CheckearFloor;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, JumpForce);
        PuedoSaltar = false;
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Suelo")
        {

            PuedoSaltar = true;

        }
    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && PuedoSaltar == true)
        {
            Jump();
        }
    }
}
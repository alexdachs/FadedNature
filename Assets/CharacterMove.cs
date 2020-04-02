using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D body;
    SpriteRenderer sprite;

    public float MaxSpeed = 0f;
    public int HP;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        float Xdireccion = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(MaxSpeed));
        body.velocity = new Vector2(Xdireccion * MaxSpeed, body.velocity.y);
    }
    private void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            sprite.flipX = false;
        }

        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            sprite.flipX = true;
        }

    }

}
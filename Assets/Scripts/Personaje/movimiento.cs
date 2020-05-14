using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private Rigidbody2D body;
    public float MaxSpeed = 8f;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float Xdireccion = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(Xdireccion * MaxSpeed, body.velocity.y);

        if(Xdireccion == 0) {
            anim.SetBool("move", false);

        }
        else {
            anim.SetBool("move", true);
        }
    }
}

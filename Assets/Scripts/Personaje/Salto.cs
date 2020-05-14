using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{



    private Rigidbody2D rb;
    private float jumpTimeCounter;
    public float jumpTime;
    public float jumpForce;
    private bool isJumping = false;
    BoxCollider2D Box2D;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Box2D = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isJumping == false)
        {


            Jump();
        }

    }



    void Jump()
    {

        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        isJumping = true;

    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            if (isJumping)
            {
                bool col1 = false;
                bool col2 = false;
                bool col3 = false;
                float center_x = (Box2D.bounds.min.x + Box2D.bounds.max.y) / 2;
                Vector2 centerPosition = new Vector2(center_x, Box2D.bounds.min.y);
                Vector2 leftPosition = new Vector2(Box2D.bounds.min.x, Box2D.bounds.min.y);
                Vector2 rightPosition = new Vector2(Box2D.bounds.max.x, Box2D.bounds.min.y);

                RaycastHit2D[] hits = Physics2D.RaycastAll(centerPosition, -Vector2.up, 2);
                if (checkRaycastWithScenario(hits)) { col1 = true; }

                hits = Physics2D.RaycastAll(leftPosition, -Vector2.up, 2);
                if (checkRaycastWithScenario(hits)) { col2 = true; }

                hits = Physics2D.RaycastAll(rightPosition, -Vector2.up, 2);
                if (checkRaycastWithScenario(hits)) { col3 = true; }

                if (col1 || col2 || col3) { isJumping = false; }
            }
        }
    }
    private bool checkRaycastWithScenario(RaycastHit2D[] hits)
    {
        foreach (RaycastHit2D hit in hits)
        {
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "Suelo")
                {
                    return true;
                }
            }
        }
        return false;
    }





}

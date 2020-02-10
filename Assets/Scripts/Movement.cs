using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D body;
    public float MaxSpeed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float Xdireccion = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(Xdireccion * MaxSpeed, body.velocity.y);
    }
}
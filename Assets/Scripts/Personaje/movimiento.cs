using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private Rigidbody2D body;
    public float MaxSpeed = 8f;

    private Animator animator;
    private int runParamID;
    private int jumpParamID;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
        runParamID = Animator.StringToHash("Running");
        jumpParamID = Animator.StringToHash("Jumping");
    }

    // Update is called once per frame
    void Update()
    {
        float Xdireccion = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(Xdireccion * MaxSpeed, body.velocity.y);

        if (Input.GetKeyDown(KeyCode.D))
        {
            bool isRunning = animator.GetBool(runParamID);
            animator.SetBool(runParamID, !isRunning);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            bool isRunning = animator.GetBool(runParamID);
            animator.SetBool(runParamID, !isRunning);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger(jumpParamID);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationCal : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer spr_render;
    Calabacinos controller;
    // Start is called before the first frame update
    void Start()
    {
        spr_render = GetComponent<SpriteRenderer>();
        controller = GetComponent<Calabacinos>();
        spr_render.enabled = false;
        controller.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TriggerActivate")
        {
            spr_render.enabled = true;
            controller.enabled = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform Start, End;
    public GameObject follow;
    public int maxpos, minpos;
    public int maxposy, minposy;


    // Update is called once per frame
    void FixedUpdate()
    {

        float posx = follow.transform.position.x;
        float posy = follow.transform.position.y;

        transform.position = new Vector3(Mathf.Clamp(posx, minpos, maxpos), posy, transform.position.z);
        if (transform.position.x <= Start.position.x)
        {
            transform.position = new Vector3(Start.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= End.position.x)
        {
            transform.position = new Vector3(End.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.y >= maxposy)
        {
            transform.position = new Vector3(transform.position.x, maxposy, transform.position.z);
        }
        if (transform.position.y <= minposy)
        {
            transform.position = new Vector3(transform.position.x, minposy, transform.position.z);
        }
    }
}

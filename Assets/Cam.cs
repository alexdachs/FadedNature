using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform Start, End;
    public GameObject follow;
    public int maxpos;
   

    // Update is called once per frame
    void FixedUpdate()
    {

        float posx = follow.transform.position.x;

        transform.position = new Vector3(Mathf.Clamp(posx, 0, maxpos), transform.position.y, transform.position.z);
        if (transform.position.x <= Start.position.x)
        {
            transform.position = new Vector3(Start.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= End.position.x)
        {
            transform.position = new Vector3(End.position.x, transform.position.y, transform.position.z);
        }
    }
}

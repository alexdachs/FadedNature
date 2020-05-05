using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject follow;
    public int maxpos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posx = follow.transform.position.x;

        transform.position = new Vector3(Mathf.Clamp(posx, 0, maxpos), transform.position.y, transform.position.z);
    }
}

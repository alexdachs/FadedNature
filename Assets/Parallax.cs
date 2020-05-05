using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, start;
    public GameObject cam;
    public float parallaxEfefct;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEfefct));
        float dist = (cam.transform.position.x * parallaxEfefct);

        transform.position = new Vector3(start + dist, transform.position.y, transform.position.z);
        if (temp > start + length)
        {
            start += length;
        } else if(temp <start - length)
        {
            start -= length;
        }
    }
    
}

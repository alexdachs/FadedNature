using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField]

    GameObject personaje;

    [SerializeField]
    float timeOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = personaje.transform.position;
        endPos.z = -20;
     
        transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);
    }
}

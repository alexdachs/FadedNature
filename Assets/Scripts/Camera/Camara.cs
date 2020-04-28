using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    GameObject personaje;

    [SerializeField]
    float timeOffset;

    [SerializeField]
    float LimiteRight;

    [SerializeField]
    float LimiteLeft;

    [SerializeField]
    float LimiteUp;

    [SerializeField]
    float LimiteDown;

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

        transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x, LimiteLeft, LimiteRight),
            Mathf.Clamp(transform.position.x, LimiteDown, LimiteUp),
            transform.position.z
        );
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    [SerializeField]

    GameObject personaje;

    [SerializeField]
    float timeOffset;

    [SerializeField]
    Vector2 posOffset;

    [SerializeField]
    float LimiteRight;

    [SerializeField]
    float LimiteLeft;

    [SerializeField]
    float LimiteUp;

    [SerializeField]
    float LimiteDown;

    Vector3 startPos;
    Vector3 endPos;
    // Update is called once per frame
    void Update()
    {
        //posicion de la camara
        startPos = transform.position;

        //posicion de megaman
        endPos = personaje.transform.position;

        endPos.x += posOffset.x;
        endPos.y += posOffset.y;
        endPos.z = -20;

        transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);

       /* transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x, LimiteLeft, LimiteRight),
            Mathf.Clamp(transform.position.x, LimiteDown, LimiteUp),
                transform.position.z
        );*/
    }
}

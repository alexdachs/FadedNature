using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrulla : MonoBehaviour
{
    
    public Transform[] puntos;
    public Transform[] puntosReverse;
    private int DestinationPoint = 0;
    private int DestinationPointReverse = 0;
    public float speed = 1;
    bool patrulla = true;
    bool reverse = false;
    
    // Start is called before the first frame update
    void Start()
    {        
        NextPoint();
    }
    void NextPoint()
    {
        if (puntos.Length == 0)
        {
            return;
        }
        if (!reverse)
        {
            transform.position = Vector2.MoveTowards(transform.position, puntos[DestinationPoint].position, speed * Time.deltaTime);
        }
        if (reverse)
        {
            transform.position = Vector2.MoveTowards(transform.position, puntosReverse[DestinationPointReverse].position, speed * Time.deltaTime);
        }
       
        
    }
    // Update is called once per frame
    void Update()
    {
        if (patrulla == true )
        {
            NextPoint();
        }
        if (Vector3.Distance(transform.position, puntos[DestinationPoint].position) < 0.5f && DestinationPoint != puntos.Length && reverse == false)
        {
            DestinationPoint += 1;
        }
        if (Vector3.Distance(transform.position, puntosReverse[DestinationPointReverse].position) < 0.5f && DestinationPointReverse != puntosReverse.Length && reverse == true)
        {
            DestinationPointReverse += 1;
        }

        if (DestinationPoint == puntos.Length)
        {
            DestinationPointReverse = 1;
            DestinationPoint = 0;
            reverse = true;
        }
        if(DestinationPointReverse == puntosReverse.Length)
        {
            DestinationPoint = 1;
            DestinationPointReverse = 0;
            reverse = false;
        }
    }
}

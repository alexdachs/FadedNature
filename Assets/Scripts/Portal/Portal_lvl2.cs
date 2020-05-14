using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal_lvl2 : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            SceneManager.LoadScene("ToBeContinued");
        }
    }
}


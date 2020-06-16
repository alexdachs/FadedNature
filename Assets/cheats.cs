using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cheats : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Tutorial_prueba");
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("NewLvl");
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Level2");
        }
    }
}

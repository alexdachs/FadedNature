using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class defeated : MonoBehaviour
{
public void BackToMenu ()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Restart ()
    {
        SceneManager.LoadScene("Level1");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class options : MonoBehaviour
{
    public Button  _GoBackButton, Res1, Res2, Res3, Res4;
    private void Start()
    {
        Res1.onClick.AddListener(ChangeRes1);
        Res2.onClick.AddListener(ChangeRes2);
        Res3.onClick.AddListener(ChangeRes3);
        Res4.onClick.AddListener(ChangeRes4);
        _GoBackButton.onClick.AddListener(GoBack);

    }
   
    void GoBack()
    {
        SceneManager.LoadScene("Menu");
    }

    void ChangeRes1() { Screen.SetResolution(800, 600,true); }
    void ChangeRes2() { Screen.SetResolution(1024, 768, true); }
    void ChangeRes3() { Screen.SetResolution(1280, 800, true); }
    void ChangeRes4() { Screen.SetResolution(1920, 1080, true); }

}

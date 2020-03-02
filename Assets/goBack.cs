using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goBack : MonoBehaviour
{
    public Button _BackButon;
    void Start()
    {
        _BackButon.onClick.AddListener(GoBack);
    }

    void GoBack()
    {
        SceneManager.LoadScene("Menu");
    }
}

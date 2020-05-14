using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class play : MonoBehaviour
{
    public Button _pButon, _oButton, _cButton, _eButton ;
    private void Start()
    {
        _pButon.onClick.AddListener(StartPlay);
        _oButton.onClick.AddListener(StartOptions);
        _cButton.onClick.AddListener(StartCredits);
        _eButton.onClick.AddListener(Exit);

    }
    void StartPlay()
    {
        SceneManager.LoadScene("Tutorial_prueba");
    }
    void StartOptions()
    {
        SceneManager.LoadScene("Options");
    }
    void StartCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    void Exit()
    {
        Application.Quit();
    }


}

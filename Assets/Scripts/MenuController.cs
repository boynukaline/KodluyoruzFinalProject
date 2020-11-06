﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private Button _startButton;
  

    void Start()
    {
        _startButton.onClick.AddListener(StartButtonFunction);
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void StartButtonFunction()
    {
        SceneManager.LoadScene("Main");
    }

   

}


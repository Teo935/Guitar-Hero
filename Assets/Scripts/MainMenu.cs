﻿

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

 public void playlevel()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Quitlevel()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
  
}
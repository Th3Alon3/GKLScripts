using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public GameObject Canvas;
    
    bool Paused = false;
    public bool pauseuı;
    public GameObject controller;
    void Start(){
        Canvas.gameObject.SetActive (false);
    }
 
    void Update () {
        if (pauseuı) 
        {
            
            Time.timeScale = 0.0f;
            Canvas.gameObject.SetActive (true);
            Screen.lockCursor = false;
            Paused = true;
            controller.SetActive(false);
            pauseuı = false;
        }
    }
    public void Resume(){
        Time.timeScale = 1.0f;
        Canvas.gameObject.SetActive (false);
        Screen.lockCursor = true;
        
    }
    public void onClick()
    {
        pauseuı = true;
    }
      
}

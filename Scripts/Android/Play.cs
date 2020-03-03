using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
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
            
            Resume();
            Paused = false;
            pauseuı = false;
        }
    }
    public void Resume(){
        Time.timeScale = 1.0f;
        Canvas.gameObject.SetActive (false);
        controller.SetActive(true);
        
    }
    public void onClick()
    {
        pauseuı = true;
    }
}

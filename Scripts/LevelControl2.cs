using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl2 : MonoBehaviour
{
    public int index;
    
    

   
    void Start()
    {
        SceneManager.LoadScene(index);
    }

    void Update(){

    }
    /*void OnTriggerEnter2D (Collider2D other) 
    {
      
    }*/
        
}

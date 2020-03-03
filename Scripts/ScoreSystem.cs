using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int score;
    private Text scoretext;
    
    
    void Start() {
        scoretext = GetComponent<Text>();
        
    }

    void Update() {
        scoretext.text = "" + score;
        
    } 
}

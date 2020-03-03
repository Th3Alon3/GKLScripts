using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCountUI2 : MonoBehaviour
{
    
    public RifleAndroid rifle;
    public Text text;

    void Awake () {
        
        rifle = GetComponent<RifleAndroid>();
        
    }

    // Update is called once per frame
    void Update () {
        text.text = "Mermi : " + rifle.currentAmmo;
    }

}

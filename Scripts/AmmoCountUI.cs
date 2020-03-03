using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCountUI : MonoBehaviour
{
    
    public PistolAndroid pistol;
    public Text text;

    void Awake () {
        
        pistol = GetComponent<PistolAndroid>();
        
    }

    // Update is called once per frame
    void Update () {
        text.text = "Mermi : " + pistol.currentAmmo;
    }

}

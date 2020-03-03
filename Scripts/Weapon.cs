using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    private SwitchGun switchGun;
    private PistolAndroid pistolScript;
    private RifleAndroid rifle;
    private AmmoCountUI ammoui;
    private AmmoCountUI2 ammoui2;
    public GameObject text1;
    public GameObject text2;
    public Animator anim;
    public AudioSource fiveshot;
    public AudioSource fivereload;
    public AudioSource akshot;
    public AudioSource akreload;
    
    

    void Start()
    {
        ammoui2 = GetComponent<AmmoCountUI2>();
        ammoui = GetComponent<AmmoCountUI>();
        switchGun = GetComponent<SwitchGun>();
        pistolScript = GetComponent<PistolAndroid>();
        rifle = GetComponent<RifleAndroid>();
        fivereload.enabled = true;
        fiveshot.enabled = true;
        pistolScript.enabled = true;
        ammoui.enabled = true;
        text1.SetActive(true);
    }
    

    // Update is called once per frame
    void Update()
    {
       
        if(switchGun.Gun1.activeSelf)
        {
            ammoui.enabled = true;
            ammoui2.enabled = false;
            rifle.enabled = false;
            pistolScript.enabled = true;
            text1.SetActive(true);
            text2.SetActive(false);
            akshot.enabled = false;
            akreload.enabled = false;
            fiveshot.enabled = true;
            fivereload.enabled= true;
        }

        if(switchGun.Gun2.activeSelf)
        {
            pistolScript.enabled = false;
            rifle.enabled = true;
            ammoui.enabled = false;
            ammoui2.enabled = true;
            text2.SetActive(true);
            text1.SetActive(false);
            akshot.enabled = true;
            akreload.enabled = true;
            fiveshot.enabled = false;
            fivereload.enabled= false;
        }

        
        
    }

   
    
}

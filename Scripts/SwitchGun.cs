using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGun : MonoBehaviour
{
    public GameObject Gun1;
    public GameObject Gun2;

    public bool switchgun;
    
    

    // Update is called once per frame
    void Update()
    {
        if(switchgun)
        {
            if(Gun1.activeSelf)
            {
                Gun1.SetActive(false);
                Gun2.SetActive(true);
                switchgun = false;
            } else if(Gun2.activeSelf)
            {
                
                Gun1.SetActive(true);
                Gun2.SetActive(false);
                switchgun = false;
            }
        }
        
            
        
    }

    public void onClick()
    {
        switchgun = true;
    }

    
    
}

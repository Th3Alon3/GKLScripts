using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveLeft : MonoBehaviour
{   
    public Rigidbody2D rigidbody;
    public float speed;
    public AudioSource carEngine;
    public AudioSource carEngineHold;
    public void onPress()
    {
        rigidbody.velocity = -transform.right * speed;
        
        carEngine.Play();
        carEngineHold.Stop();
        transform.localScale = new Vector3 (-1.3f, 1.3f, 1);;
    
    }

    // Update is called once per frame
    public void onRelease ()
    {
        rigidbody.velocity = -transform.right * 0;
        
        carEngine.Stop();
        carEngineHold.Play();
        
            
    }
}

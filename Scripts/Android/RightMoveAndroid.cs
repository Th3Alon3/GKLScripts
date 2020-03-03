using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightMoveAndroid : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float speed;
    public Animator animator;
    public static bool m_FacingRight = true;
    public AudioSource footStep;



    // Start is called before the first frame update
    public void onPress()
    {
        rigidbody.velocity = transform.right * speed;
        animator.SetFloat("Speed", Mathf.Abs(speed));
        footStep.Play();
        
		transform.localScale = new Vector3 (0.55f, 0.55f, 1);
        
    }

    // Update is called once per frame
    public void onRelease ()
    {
        rigidbody.velocity = -transform.right * 0;
        animator.SetFloat("Speed", Mathf.Abs(0));
        footStep.Stop();
        
            
    }

    
}

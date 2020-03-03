using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
 
    public float speed = 20f;
   
    public Rigidbody2D rb;

    public Sprite FlashSprite;
    [Range(0,5)]
    public int FramesToFlash = 1;
    void Start()
    {   
        if(FlashSprite != null){
            StartCoroutine(DoFlash());
        }
        
        rb.velocity = transform.right * speed;
    }
    void OnCollisionEnter2D (Collision2D col)
    {
        Destroy(gameObject);
    }

    IEnumerator DoFlash(){
        var renderer = GetComponent<SpriteRenderer>();
        var originalSprite = renderer.sprite;
        renderer.sprite = FlashSprite;
        var framesFlashed = 0;
        renderer.sprite = originalSprite;
        while (framesFlashed < FramesToFlash)
        {
            framesFlashed++;
            yield return null;
        }
    }
    
    
}

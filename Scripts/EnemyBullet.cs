using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    
    public Rigidbody2D rb;
    public Collider2D collider;
    public Sprite FlashSprite;
    [Range(0,5)]
    public int FramesToFlash = 1;

   
    void Start()
    {
        if(FlashSprite != null){
            StartCoroutine(DoFlash());
        }
        rb.velocity = -transform.right  *  speed;

    }
    void OnCollisionEnter2D (Collision2D col)
    {   
        if (col.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreLayerCollision(13, 15, true);
            
        }else{
            Destroy(gameObject);
        }
        
       
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

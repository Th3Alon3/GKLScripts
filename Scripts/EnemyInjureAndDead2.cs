using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInjureAndDead2 : MonoBehaviour
{
    public int health;
    public int pdamage = 20;
    public int tdamage = 50;
    public GameObject bloodsplash;
    public GameObject bloodsplash2;
    public Rigidbody2D rb;
    public GameObject blood;
    public GameObject blood2;
    public GameObject blood3;
    public Animator anim;
    public WeaponEnemy2 we;
    private EnemyArcadeRf arcade;
    public AudioSource hurtsound;
    
    
    
    void Start()
    {
  
        arcade = GetComponent<EnemyArcadeRf>();
        we = GetComponent<WeaponEnemy2>();
        arcade.enabled = true;
        we.enabled = true;
       
    }
    void OnCollisionEnter2D (Collision2D col)
    {   
        
        if(col.gameObject.tag.Equals("bullet"))
        {
            if(health <= 0)
            {
                hurtsound.Play();
                rb.bodyType = RigidbodyType2D.Static;
                blood.SetActive(true);
                anim.SetTrigger("IsDead");
                arcade.enabled = false;
                bloodsplash2.SetActive(true);
                we.enabled = false;
                ScoreSystem.score += 10;
                Destroy(gameObject,10);
                
                
                
                
            }else
            {
                hurtsound.Play();
                health = health - pdamage;
                anim.SetTrigger("IsHurt");
                rb.bodyType = RigidbodyType2D.Static;
                blood2.SetActive(true);
                blood3.SetActive(true);
                bloodsplash.SetActive(true);
                
                
            }
            
        }
        if(col.gameObject.tag.Equals("tbullet"))
        {
            if(health <= 0)
            {
                hurtsound.Play();
                rb.bodyType = RigidbodyType2D.Static;
                blood.SetActive(true);
                anim.SetTrigger("IsDead");
                arcade.enabled = false;
                bloodsplash2.SetActive(true);
                Destroy(gameObject,10);
                ScoreSystem.score += 8;
                we.enabled = false;
                
                
            }else
            {
                hurtsound.Play();
                health = health - tdamage;
                anim.SetTrigger("IsHurt");
                rb.bodyType = RigidbodyType2D.Static;
                blood2.SetActive(true);
                blood3.SetActive(true);
                bloodsplash.SetActive(true);
                
                
            }
            
        }

        
        
            
        
    }
}

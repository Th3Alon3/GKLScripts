using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterInjureandDead : MonoBehaviour
{
    public int health;
    public int pdamage = 20;
    public int tdamage = 50;
    public GameObject bloodsplash;
    public GameObject bloodsplash2;
    public GameObject blood;
    public GameObject blood2;
    public GameObject blood3;
    public Animator anim;
    public AudioSource hurtsound;
    public GameObject respawn;
    public GameObject respawn2;
    public GameObject movecontrol;

  
    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag.Equals("ebullet"))
        {
            if(health <= -10)
            {
                
                hurtsound.Play();
                blood.SetActive(true);
                anim.SetTrigger("IsDead");
                GetComponent<CapsuleCollider2D>().enabled = false;
                bloodsplash2.SetActive(true);
                respawn.SetActive(false);
                respawn2.SetActive(false);
                movecontrol.SetActive(false);
               
                
                
              
                
                
                
            }else
            {
                hurtsound.Play();
                health = health - pdamage;
                anim.SetTrigger("IsHurt");
                blood2.SetActive(true);
                blood3.SetActive(true);
                bloodsplash.SetActive(true);
            }
            
        }
        if(col.gameObject.tag.Equals("etbullet"))
        {
            if(health <= -5)
            {
                
                hurtsound.Play();
                blood.SetActive(true);
                anim.SetTrigger("IsDead");
                GetComponent<CapsuleCollider2D>().enabled = false;
                bloodsplash2.SetActive(true);
                respawn.SetActive(false);
                respawn2.SetActive(false);
                movecontrol.SetActive(false);
                
                
                
                
                
                
            }else
            {
                hurtsound.Play();
                health = health - tdamage;
                anim.SetTrigger("IsHurt");
                blood2.SetActive(true);
                blood3.SetActive(true);
                bloodsplash.SetActive(true);
                
                
                
            }
            
        }
    }
    
    
}

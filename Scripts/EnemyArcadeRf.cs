using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArcadeRf : MonoBehaviour
{
    public float speed;
    public float stoppingDistancemax;
    public float stoppingDistancemin;
    private Transform target;
    public Animator anim;
    private WeaponEnemy weapon;
    public AudioSource footstep;
    // Start is called before the first frame update
    void Start()
    {
        weapon = GetComponent<WeaponEnemy>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        weapon.enabled = false;
    }

    void Update()
    {
        float a = Vector2.Distance(transform.position, target.position);   
        if(a >= stoppingDistancemin && a <= stoppingDistancemax)
        {
            footstep.Stop();
            anim.SetFloat("Speed", Mathf.Abs(0));
            weapon.enabled = true;  
           
        }else
        {
            footstep.Play();
            anim.SetFloat("Speed", Mathf.Abs(speed));
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime); 
            
        }
        
        
    }

   
}

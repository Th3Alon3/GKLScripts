using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEnemy2 : MonoBehaviour
{
    public GameObject tbullet;
    public Transform firePoint;
    public float fireRate;
    public float nextfire;
    public GameObject MuzzleFlash;
    [Range(0,5)]
    public int FramesToFlash = 1;
    bool isFlashing = false;
    public int MaxAmmo = 30;
    private int currentAmmo;
    public float reloadTime = 1.5f;
    private bool isReloading = false;
    public Animator anim;
    public AudioSource shotsound;
    public AudioSource reloadsound;

    
    void Start(){
    
        MuzzleFlash.SetActive(false);
        currentAmmo = MaxAmmo;
                
    }
    void OnEnable()
    {
        isReloading = false;
        anim.SetBool("AkReload", false);
    }
    void Update() {
        if (isReloading)
        {
            return;
        }
        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }    
        
        
        if(Time.time > nextfire) {
            
            nextfire = Time.time + fireRate;
            Shoot();
        }
    }
    
    IEnumerator Reload()
    {
        reloadsound.Play();
        isReloading = true;
        anim.SetBool("AkReload", true);
        yield return new WaitForSeconds(reloadTime- .25f);
        anim.SetBool("AkReload", false);
        yield return new WaitForSeconds(.25f);
        currentAmmo = MaxAmmo;
        isReloading = false;
        
    }
    void Shoot()
    {
        Instantiate(tbullet, firePoint.position, firePoint.rotation);
        if(MuzzleFlash != null && !isFlashing)
        {
            StartCoroutine(DoFlash());
        }
        currentAmmo--;
        shotsound.Play();
    }
    
    IEnumerator DoFlash()
    {
        MuzzleFlash.SetActive(true);
        var framesFlashed = 0;
        isFlashing = true;

        while(framesFlashed <= FramesToFlash){
            framesFlashed++;
            yield return null;
        }

        MuzzleFlash.SetActive(false);
        isFlashing = false;
    }
}

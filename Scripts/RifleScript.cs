using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleScript : MonoBehaviour
{
    public GameObject tbulletPrefab;
    public Transform firePoint2;
    public Animator anim;
    public float fireRate;
    public float nextFire;
    public GameObject MuzzleFlash;
    [Range(0,5)]
    public int FramesToFlash = 1;
    bool isFlashing = false;
   
    public int MaxAmmo = 30;
    public int currentAmmo;
    public float reloadTime = 1.5f;
    private bool isReloading = false;
    public int magcount;
    public AudioSource shootaudio;
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
    // Update is called once per frame
    void Update()
    {
        
        if (isReloading)
        {
            return;
        }
        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            
            nextFire = Time.time + fireRate;
            anim.SetBool("AkFire", true);
            Shoot();
           
        }else if(Input.GetButtonUp("Fire1") )
        {
            anim.SetBool("AkFire",false);
        }
        
       
            
        
        
    }
    IEnumerator Reload()
    {
        reloadsound.Play();
        isReloading = true;
        anim.SetBool("AkReload",true);
       
        yield return new WaitForSeconds(reloadTime- .25f);
        anim.SetBool("AkReload",false);
        yield return new WaitForSeconds(.25f);
        currentAmmo = MaxAmmo;
        isReloading = false;
        
        
        
    }
    void Shoot()
    {
        if(!isFlashing)
        {
            StartCoroutine(DoFlash());
        }
        Instantiate(tbulletPrefab, firePoint2.position, firePoint2.rotation);
        currentAmmo--;
        shootaudio.Play();
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

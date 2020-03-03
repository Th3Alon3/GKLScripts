using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleAndroid : MonoBehaviour
{
    public Transform firePoint;
    public Animator anim;
    public GameObject pbulletPrefab;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
    public GameObject MuzzleFlash;
    [Range(0,5)]
    public int FramesToFlash = 1;
    bool isFlashing = false;
    public int MaxAmmo = 20;
    public int currentAmmo;
    public float reloadTime = 1f;
    private bool isReloading = false;
    public AudioSource shootaudio;
    public AudioSource reloadsound;
    public bool press;
  
    void Start(){
        MuzzleFlash.SetActive(false);
        currentAmmo = MaxAmmo;
        
    }

    void OnEnable()
    {
        isReloading = false;
        anim.SetBool("FiveReload", false);
    }
    public void Update()
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
        
        if (press && Time.time > nextFire)
        {    
            Shoot();
            nextFire = Time.time + fireRate;
            anim.SetBool("AkFire", true);
        }
        else if(!press)
        {
            anim.SetBool("AkFire", false);
        }
    }
   
    public void onPress()
    {
        press = true;
    }
    public void onRelease()
    {
        press = false;
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

	public void Shoot(){

        Instantiate(pbulletPrefab, firePoint.position, firePoint.rotation);
        if(!isFlashing)
        {
            StartCoroutine(DoFlash());
        }
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

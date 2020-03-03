using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolScript : MonoBehaviour
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
   
    


    
    void Start(){
        MuzzleFlash.SetActive(false);
        currentAmmo = MaxAmmo;
        
        
        
    }
    void OnEnable()
    {
        isReloading = false;
        anim.SetBool("FiveReload", false);
    }
    void Update () {

        
        
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
            Shoot();
            nextFire = Time.time + fireRate;
            anim.SetBool("IsFire", true);
			
		} else if (Input.GetButtonUp("Fire1"))
        {
            anim.SetBool("IsFire", false);
        }
       
        

        
           

            
        
        
	}

    IEnumerator Reload()
    {
        reloadsound.Play();
        isReloading = true;
        anim.SetBool("FiveReload", true);
        yield return new WaitForSeconds(reloadTime- .25f);
        
        anim.SetBool("FiveReload", false);
        yield return new WaitForSeconds(.25f);
        currentAmmo = MaxAmmo;
        isReloading = false;
        
       
    }

	void Shoot(){

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

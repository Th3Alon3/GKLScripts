using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVideo : MonoBehaviour
{
    public RawImage image;
    public VideoPlayer vplayer;
    
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayVideo());
    }

    IEnumerator PlayVideo()
    {
        vplayer.Prepare();
        WaitForSeconds wait = new WaitForSeconds(1);
        while(!vplayer.isPrepared)
        {
            yield return wait;
            break;
        }
        image.texture = vplayer.texture;
        vplayer.Play();
        sound.Play();
    
    }   


    
}

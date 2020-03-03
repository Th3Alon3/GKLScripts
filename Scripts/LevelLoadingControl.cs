using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoadingControl : MonoBehaviour
{
   public Slider progressbar;
   public void Load(int level)
   {
       StartCoroutine(startLoading(level));

   }

    IEnumerator startLoading(int level)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(level);
        while (!async.isDone)
        {
            progressbar.value = async.progress;
            yield return null;
        }
    }
}

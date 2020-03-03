using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeVideo : MonoBehaviour
{
    public float time = 3;
    public GameObject level;
    // Start is called before the first frame update
    IEnumerator Start ()
    {
        yield return new WaitForSeconds(time);
        level.SetActive(true);
    }
}

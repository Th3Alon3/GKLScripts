﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimer : MonoBehaviour
{
    public float time = 3; //Seconds to read the text
 
    IEnumerator Start ()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}

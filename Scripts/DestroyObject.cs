using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    float lifetime = 0.5f;
    public GameObject gameObject;
    void Start ()
    { 
        Destroy (gameObject, lifetime); 
    }

}

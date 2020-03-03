using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public Transform point;
    public float secondsBetweenSpawn;
    public float elapsedTime;
    
    void Update() {
        
        if (Time.time > elapsedTime)
        {
            elapsedTime = Time.time + secondsBetweenSpawn;
            Respawn();
        }
    
    }
    void Respawn()
    {
        Instantiate(EnemyPrefab, point.position, point.rotation);
        
    }
  
}   

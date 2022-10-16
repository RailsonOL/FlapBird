using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject prefab;
    public float spawnTime = 1.5f;
    void Start()
    {
        InvokeRepeating("Spawn", 1, spawnTime);
    }

    void Spawn(){
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(prefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform[] spawnPoints;
    public float timeBetweenSpawns = 0.5f;


    private int index;
    private float currentTime;

    private void Start()
    {
        currentTime = timeBetweenSpawns;
    }

    private void Update()
    {
        if(Time.time > currentTime)
        {
            spawner();
            currentTime += timeBetweenSpawns; // currentTime = currentTime + timeBetweenSpawns
        }
    }

    public void spawner() 
    {
        if (index > 1)
        {
            index = 0;
        }
        Instantiate(platformPrefab, spawnPoints[index].position,Quaternion.identity);
        index++;
    }
}
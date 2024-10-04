using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
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
        if (GameManager.Instance.startGame)
        {
            if (Time.timeSinceLevelLoad > currentTime)
            {
                spawner();
                currentTime += timeBetweenSpawns; // currentTime = currentTime + timeBetweenSpawns
            }
        }
    }

    public void spawner()
    {
        if (index > 1)
        {
            index = 0;
        }
        Instantiate(enemyPrefab, spawnPoints[index].position, Quaternion.identity);
        index++;
    }
}

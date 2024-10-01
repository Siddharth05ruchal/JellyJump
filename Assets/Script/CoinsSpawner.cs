using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    private BoxCollider2D box;
    public Vector2 spawnArea;

    public GameObject coinPrefab;

    public float timeSpawn = 0.5f;

    private float currentTime;
    private void Start()
    {
        box = this.GetComponent<BoxCollider2D>();
        box.enabled = false;
        spawnArea = new Vector2(box.size.x / 2,box.size.y/2);

        currentTime = timeSpawn;
    }

    void SpawnCoins()
    {
        Vector2 randomPos = new Vector2(Random.Range(-spawnArea.x,spawnArea.x), Random.Range(-spawnArea.y, spawnArea.y));
        Instantiate(coinPrefab, randomPos, Quaternion.identity);
    }

    private void Update()
    {
        if (GameManager.Instance.startGame) 
        {
            if (Time.timeSinceLevelLoad > currentTime)
            {
                SpawnCoins();
                currentTime += timeSpawn;
            }
        }
      
    }
}

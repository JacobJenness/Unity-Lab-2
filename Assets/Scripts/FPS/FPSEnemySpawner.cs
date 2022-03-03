using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSEnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform spawnLocation;
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private float secondsPerSpawn;
    [SerializeField] private float lastSpawnTime;

    private int numberOfEnemies;

    // Update is called once per frame
    void Update()
    {
        numberOfEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        secondsPerSpawn -= (0.05f * Time.deltaTime);
        if(Time.time - lastSpawnTime >= secondsPerSpawn && FPSPlayer.instance.ShouldSpawn(spawnLocation.position) && numberOfEnemies <= 100)
        {
            lastSpawnTime = Time.time;
            Spawn();
        }
    }

    private void Spawn()
    {
        GameObject enemyPrefab = enemies[Random.Range(0, enemies.Length)];
        GameObject newEnemy = Instantiate(enemyPrefab);
        newEnemy.transform.position = spawnLocation.position;
    }
}

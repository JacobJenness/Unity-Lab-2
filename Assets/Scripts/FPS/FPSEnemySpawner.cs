using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSEnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float secondsPerSpawn;
    // Update is called once per frame
    void Update()
    {
        secondsPerSpawn -= (0.05f * Time.deltaTime);
    }
}

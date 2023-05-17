using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] cannonBallPrefabs;
    public float spawnRangeX = 10;
    public float spawnPosZ = 11;
    public float startDelay = 2;
    public float spawnInterval = 5;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCannonBall", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCannonBall()
    {
        // Randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2.43f, spawnPosZ);

        int enemyIndex = Random.Range(0, cannonBallPrefabs.Length);
        Instantiate(cannonBallPrefabs[enemyIndex], spawnPos,
        cannonBallPrefabs[enemyIndex].transform.rotation);
    }
}

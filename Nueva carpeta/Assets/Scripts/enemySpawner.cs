using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sp : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime;
    public float spawnTimeRandom;


    private float spawnTimer;
    private NavMeshAgent nav;
    public Transform target;
    private Vector3 location;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Mutante");
        Vector3 location = new Vector3(0, 0, 0);

        ResetSpawnTimer();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0.0f)
        {
            Instantiate(enemy, location,Quaternion.identity);
            ResetSpawnTimer();
        }
    }

    void ResetSpawnTimer()
    {
        spawnTimer = (float)(spawnTime + Random.Range(0, spawnTimeRandom * 100) / 100.0);
    }
}

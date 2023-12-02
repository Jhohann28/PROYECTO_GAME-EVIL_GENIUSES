using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject spherePrefab; // Prefab de la esfera que se duplicará
    public Transform spawnPoint; // Punto de spawn para las esferas

    public float spawnInterval = 5f; // Intervalo entre spawns

    void Start()
    {
        spawnPoint.position = new Vector3(29.87f, -5.156521f, 68.14f);
        StartCoroutine(SpawnObjectRoutine());
    }

    IEnumerator SpawnObjectRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            // Instancia una esfera en la posición del spawnPoint
            Instantiate(spherePrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}



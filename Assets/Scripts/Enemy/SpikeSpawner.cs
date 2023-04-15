using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private GameObject spike;

    [Header("Configs")]
    [SerializeField] private float spawnRadius;
    [SerializeField] private float maxSpawnWaitTime;
    [SerializeField] private float minSpawnWaitTime;

    void Start()
    {
        StartCoroutine(SpawnSpikes());
    }

    IEnumerator SpawnSpikes()
    {
        while(true)
        {
            float spawnWaitTime = Random.Range(minSpawnWaitTime, maxSpawnWaitTime);
            float angle = Random.Range(0f, 360f);
            Vector3 position = new(spawnRadius * Mathf.Cos(angle), spawnRadius * Mathf.Sin(angle), 0);
            Instantiate(spike, position, Quaternion.identity);
            yield return new WaitForSeconds(spawnWaitTime);
        }
    }
}

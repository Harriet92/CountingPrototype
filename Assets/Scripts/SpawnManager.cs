using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float baseSpawnTimeIntervalSeconds = 4;
    public float intervalDecreasePerPoint = 0.1f;
    public float minSpawnTimeInterval = 0.8f;
    public GameObject[] spawnedObjectsPrefabs;

    public float spawnPositionY;
    public float spawnPositionZ;
    public float minSpawnPositionX;
    public float maxSpawnPositionX;

    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		StartGame();
    }

    public void StartGame()
	{
        StartCoroutine(SpawnObjects());
	}

    private IEnumerator SpawnObjects()
	{
		while (gameManager.IsGameRunning)
		{
			var position = DrawPosition();
			var prefab = DrawSpawnedObject();
			Instantiate(prefab, position, prefab.transform.rotation, transform);

			yield return new WaitForSeconds(CalculateTimeInterval());
		}
	}

	private GameObject DrawSpawnedObject()
	{
		return spawnedObjectsPrefabs[UnityEngine.Random.Range(0, spawnedObjectsPrefabs.Length)];
	}

	private Vector3 DrawPosition()
	{
        return new Vector3(spawnPositionZ, spawnPositionY, UnityEngine.Random.Range(minSpawnPositionX, maxSpawnPositionX));
	}

	private float CalculateTimeInterval()
	{
		var calculated = baseSpawnTimeIntervalSeconds - intervalDecreasePerPoint * (float)gameManager.CurrentPointsGathered;

		return calculated < minSpawnTimeInterval ? minSpawnTimeInterval : calculated;
	}
}

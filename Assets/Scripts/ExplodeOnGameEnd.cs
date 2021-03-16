using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnGameEnd : MonoBehaviour
{
    public ParticleSystem ExplodeParticles;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		gameManager.GameEnded += OnGameEnded;
    }

	private void OnGameEnded()
	{
        StartCoroutine(DieWithDelay());
	}

	private IEnumerator DieWithDelay()
	{
		yield return new WaitForSeconds(UnityEngine.Random.Range(0, 3f));
		Instantiate(ExplodeParticles, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}

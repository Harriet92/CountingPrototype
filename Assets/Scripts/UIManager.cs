using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject GameOverScreen;
    private GameManager gameManager;

    void Start()
    {
        GameOverScreen.SetActive(false);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		gameManager.GameEnded += OnGameEnded;
    }

	private void OnGameEnded()
	{
        GameOverScreen.SetActive(true);
	}
}

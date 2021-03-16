using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int CurrentPointsGathered { get; private set; }
    public event Action GameEnded;

    public bool IsGameRunning { get; private set; } = true;

    public void AddPoint()
	{
        CurrentPointsGathered++;
	}

    public void GameOver()
	{
        IsGameRunning = false;
        GameEnded?.Invoke();
	}

    public void RestartGame()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}

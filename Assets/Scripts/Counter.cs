using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bad"))
            gameManager.GameOver();
        else
        {
            gameManager.AddPoint(); 
            CounterText.text = "Count : " + gameManager.CurrentPointsGathered;
        }
    }
}

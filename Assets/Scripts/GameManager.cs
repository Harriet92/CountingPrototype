using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int CurrentPointsGathered { get; private set; }
    public bool IsGameRunning { get; private set; } = true;

    public void AddPoint()
	{
        CurrentPointsGathered++;
	}

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

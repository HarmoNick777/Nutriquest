using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private DateTime startTime;
    private TimeSpan timeElapsed;
    private int finalTimeInSeconds;

    private void Start()
    {
        timeElapsed = TimeSpan.Zero;
        startTime = DateTime.Now;
    }

    private void Pause()
    {
        timeElapsed += DateTime.Now - startTime;
    }

    private void Unpause()
    {
        startTime = DateTime.Now;
    }

    public int GameDurationInSeconds()
    {
        timeElapsed += DateTime.Now - startTime;
        finalTimeInSeconds = (int)timeElapsed.TotalSeconds;
        return finalTimeInSeconds;
    }
}

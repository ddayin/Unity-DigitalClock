﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Application : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeRight;
        
        // Disable screen dimming
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
        // 배터리 소모 줄이기
        UnityEngine.Application.targetFrameRate = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

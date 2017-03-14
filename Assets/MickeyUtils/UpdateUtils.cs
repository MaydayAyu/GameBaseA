﻿using MickeyUtils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateUtils : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        MEvent.Dispatch();
        AsynCall.CallFunc();
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenResolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(576, 1024, true, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

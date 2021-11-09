﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    [SerializeField] int _openingDir;
    // 1 = Down Door
    // 2 = Up Door
    // 3 = Left Door
    // 4 = Right Door

    private void Update()
    {
        if(_openingDir == 1)
        {
            // Spawn a room UP
        }
        else if(_openingDir == 2)
        {
            // Spawn a room DOWN
        }
        else if (_openingDir == 3)
        {
            // Spawn a room to the LEFT
        }
        else if (_openingDir == 4)
        {
            // Spawn a room to the RIGHT
        }
    }

}

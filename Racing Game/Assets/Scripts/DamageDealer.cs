﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject other;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}

Damage Dealer
    wave 1: 1 Damage
    wave 2: 2 Damage
    wave 3: 3 Damage
    wave 4: 4 Damage
    wave 5: 5 Damage
    Bullet Obstacles: 1 Damage
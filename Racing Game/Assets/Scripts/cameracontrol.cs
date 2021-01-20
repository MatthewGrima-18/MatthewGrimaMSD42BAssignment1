﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public float[] RotZ;
    int triggerCount = 0;

    Camera Cam;

    bool CanRotate;

    public float rotSpeed;


    void Start()
    {
        Cam = Camera.main;
    }


    void FixedUpdate()
    {
        if(CanRotate)
        {
            Quaternion camRot = Cam.transform.rotation;
            Quaternion desRot = Quaternion.Euler(0, 0, RotZ[triggerCount - 1]);

            Cam.transform.rotation = Quaternion.Lerp(camRot, desRot, Time.deltaTime * rotSpeed);

            if(camRot.z == desRot.z)
            {
                CanRotate = false;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        if (triggerCount == 4)
            triggerCount = 0;

        triggerCount += 1;

        CanRotate = true;

    }
}
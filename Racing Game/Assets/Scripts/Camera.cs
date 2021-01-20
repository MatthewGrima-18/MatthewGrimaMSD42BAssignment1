using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Target;

    public Vector3 Offset;

    public float smoothness;

    void Update()
    {
        Vector3 delayedPos = Vector3.Lerp(transform.position, Target.position,smoothness);

        transform.position = delayedPos + Offset
    }
}
    
}
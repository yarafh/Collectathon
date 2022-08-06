using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        mainCamera=Camera.main;
    }

    
    private void Update()
    {
        float targetX=transform.position.x;
        float targetY=transform.position.y;
        float targetZ=transform.position.z;

        mainCamera.transform.position=new Vector3(targetX, targetY+10, targetZ-5);
    }
}

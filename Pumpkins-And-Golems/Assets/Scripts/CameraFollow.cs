using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform pumpkimPos;

    private float zDistance = 25f;
    private float yDistance = 4f;

    private void Awake()
    {
        pumpkimPos = GameObject.Find("Pumpkim").transform;
    }
   
    void Update()
    {
        Vector3 temp = transform.position;
        temp.y = pumpkimPos.position.y + yDistance;
        temp.z = pumpkimPos.position.z - zDistance;
        transform.position = temp;
    }
}

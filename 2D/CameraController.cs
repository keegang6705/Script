//code type : 2D
//code version : 1.0
//last working : unity2022.3.17f

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float zoomAmount = 3.0f;
    public float minZoom = 1f;
    public float maxZoom = 10f; 

    void Update()
    {
        float zoomInput = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.orthographicSize -= zoomInput * zoomAmount;
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom, maxZoom);
        transform.position = new Vector3(player.position.x+offset.x,player.position.y+offset.y,offset.z);
    }
}

//code type : 2D
//code version : 1.0
//last working : unity2022.3.17f

using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    public GameObject Object;
    public Vector3 offset;

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Object.transform.position = new Vector3(mousePosition.x + offset.x, mousePosition.y + offset.y, 0);
  
    }
}

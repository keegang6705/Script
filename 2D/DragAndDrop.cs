//code type : 2D
//code version : 1.0
//last working : unity2022.3.17f

using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Plane dragPlane;
    private Vector3 offset;
    private Camera myMainCamera;
    private Rigidbody2D rb;
    private float gravity; 

    void Start()
    {
        myMainCamera = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        gravity = rb.gravityScale;
    }

    void OnMouseDown()
    {
        rb.gravityScale = 0f;

        dragPlane = new Plane(myMainCamera.transform.forward, transform.position);
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition);
        float planeDist;
        dragPlane.Raycast(camRay, out planeDist);
        offset = transform.position - camRay.GetPoint(planeDist);
    }

    void OnMouseDrag()
    {
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition);
        float planeDist;
        dragPlane.Raycast(camRay, out planeDist);

        Vector3 newPosition = camRay.GetPoint(planeDist) + offset;

        transform.position = newPosition;

        Vector3 velocity = (newPosition - transform.position) / Time.deltaTime;

        rb.velocity = velocity;
    }

    void OnMouseUp()
    {
        rb.gravityScale = gravity;
    }
}

//code type : 2D,3D
//code version : 1.0
//last working : unity2022.3.17f

using UnityEngine;

public class ObjectCloner : MonoBehaviour
{
    public GameObject objectToClone;
    public GameObject targetObject;
    public bool useTargetPosition = true;
    public bool useTargetRotation = true;
    public Vector3 positionOffset;
    public Vector3 rotationOffset;
    public Vector3 addVelocity;
    
    public string clonedObjectName = "ClonedObject";
    public float cloneLifetime = -1f;
    public string clonedObjectTag = "Untagged";

    public void CloneObject()
    {
        GameObject clone = Instantiate(objectToClone, transform.position, transform.rotation);
        clone.name = clonedObjectName;
        if (targetObject != null)
        {
            if (useTargetPosition)
            {
                clone.transform.position = targetObject.transform.position + positionOffset;
            }

            if (useTargetRotation)
            {
                clone.transform.rotation = targetObject.transform.rotation * Quaternion.Euler(rotationOffset);
            }
        }

        Rigidbody2D cloneRigidbody = clone.GetComponent<Rigidbody2D>();
        if (cloneRigidbody != null)
        {
            cloneRigidbody.velocity = addVelocity;
        }
        else
        {
            Debug.Log("cloned object doesn't have a rigidbody");
        }

        if (!string.IsNullOrEmpty(clonedObjectTag))
        {
            clone.tag = clonedObjectTag;
        }

        if (cloneLifetime > 0f)
        {
            Destroy(clone, cloneLifetime);
        }
    }
}

//code type : 2D,3D_Testing
//code version : 1.1
//last working : unity2022.3.25f

using UnityEngine;

public class ObjectSpinner : MonoBehaviour
{
  public float starterRotationSpeed = 100f;
  public float currentRotationSpeed = 0f;
  public float rotationSpeedMultiplier = 0f;
  public bool isSpinning = true;
  public void StartSpin(){
    isSpinning = true;
  }
  public void StopSpin(){
    isSpinning = false;
  }
  void Start(){
    currentRotationSpeed = starterRotationSpeed;
  }
  void Update()
  {
    if (isSpinning){
    currentRotationSpeed += rotationSpeedMultiplier;
    transform.Rotate(Vector3.forward * currentRotationSpeed * Time.deltaTime);
    }
  }


}

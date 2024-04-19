//code type : 2D
//code version : 1.0
//last working : unity2022.3.17f

using UnityEngine;

public class CamRGB : MonoBehaviour
{
  public Camera myCamera;
  private Color Default_color;
  public float speed = 0.01f;
  public bool enable = true;
  private float hue = 0f;
  public void Reset(){
    myCamera.backgroundColor = Default_color;
  }
  public void ResetHue(){
    hue = 0f;
  }
  public void Toggle(){
    enable = !enable;
  }
  public void SetDefaultColor(){
    Default_color = myCamera.backgroundColor;
  }
 void Start() {
    Default_color = myCamera.backgroundColor;
}
  void Update()
  {
    if (enable){
    hue += Time.deltaTime * speed;
    hue %= 1.0f;

    myCamera.backgroundColor = Color.HSVToRGB(hue, 1f, 1f);
    }
  }
}

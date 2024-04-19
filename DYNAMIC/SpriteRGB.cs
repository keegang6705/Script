//code type : 2D,3D
//code version : 1.0
//last working : unity2022.3.17f

using UnityEngine;

public class SpriteRGB : MonoBehaviour
{
  public SpriteRenderer mySpriteRenderer;
  private Color Default_color;
  public float speed = 0.05f;
  public bool enable = true;
  private float hue = 0f;
  public void Reset(){
    mySpriteRenderer.color = Default_color;
  }
  public void ResetHue(){
    hue = 0f;
  }
  public void Toggle(){
    enable = !enable;
  }
  public void SetDefaultColor(){
    Default_color = mySpriteRenderer.color;
  }
 void Start() {
    Default_color = mySpriteRenderer.color;
}
  void Update()
  {
    if (enable){
    hue += Time.deltaTime * speed;
    hue %= 1.0f;

    mySpriteRenderer.color = Color.HSVToRGB(hue, 1f, 1f);
    }
  }
}

//code type : 2D,3D
//code version : 1.0
//last working : unity2022.3.17f

using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class LoopController
 : MonoBehaviour
{
    public float interval = 0f;
    public bool active = true;
    public UnityEvent Event;
    void Start (){
        StartCoroutine(LoopEvent());
    }
    public void StartLoop(){
        StopAllCoroutines();
        active=true;
        StartCoroutine(LoopEvent());
    }
    public void StopLoop(){
        active=false;
        StopAllCoroutines();
    }
    public void Toggle(){
        if (active){
            StopLoop();
        } else{
            StartLoop();
        }
    }
    private IEnumerator LoopEvent()
    {
        while (active) {
        yield return new WaitForSeconds(interval);
        Event.Invoke();
        }
        StopAllCoroutines();
        
    }
}

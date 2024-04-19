//code type : 2D,3D
//code version : 1.0
//last working : unity2022.3.25f

using UnityEngine;
using UnityEngine.Events;
using System.Collections;

[System.Serializable]
public class KeyEvent_
{
    public KeyCode key;
    public bool holdToLoopTrigger;
    public float interval = 0.01f;
    public UnityEvent onKeyPress;
    public UnityEvent onKeyHold;
    public UnityEvent onKeyRelease;
}

public class KeyEvent : MonoBehaviour
{
    
    public KeyEvent_[] keyEvents;

    void Update()
    {
        CheckKeyEvents();
    }

    private void CheckKeyEvents()
    {
        foreach (var keyEvent in keyEvents)
        {
            if (Input.GetKeyDown(keyEvent.key))
            {
                

                if (keyEvent.holdToLoopTrigger)
                {
                    StartCoroutine(LoopKeyHoldEvent(keyEvent));
                } else {
                    keyEvent.onKeyPress.Invoke();
                }
            }
            else if (Input.GetKeyUp(keyEvent.key))
            {
                keyEvent.onKeyRelease.Invoke();
            }
        }
    }

    private IEnumerator LoopKeyHoldEvent(KeyEvent_ keyEvent)
    {
        keyEvent.onKeyPress.Invoke();
        yield return new WaitForSeconds(keyEvent.interval);
        while (Input.GetKey(keyEvent.key))
        {
            keyEvent.onKeyHold.Invoke();
            yield return new WaitForSeconds(keyEvent.interval);
        }
    }
}

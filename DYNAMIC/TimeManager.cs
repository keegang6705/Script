//code type : 2D,3D
//code version : 1.2
//last working : unity2022.3.25f

using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public bool isPaused = false;
    [Range(0.0f, 100.0f)]
    public float customSpeed = 2f;
    public void TogglePause()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }
    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }
    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
    }
    public void CustomSpeedPlay()
    {
        isPaused = false;
        Time.timeScale = customSpeed;
    }
    public void x2Play()
    {
        isPaused = false;
        Time.timeScale = 2f;
    }
    public void x4Play()
    {
        isPaused = false;
        Time.timeScale = 4f;
    }
    public void x10Play()
    {
        isPaused = false;
        Time.timeScale = 10f;
    }

}

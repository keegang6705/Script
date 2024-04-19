//code type : 2D,3D
//code version : 1.1
//last working : unity2022.3.25f

using System.Collections;
using System.Collections.Generic;
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
            ResumeGame()
        }
        else
        {
            PauseGame()
        }
    }
    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.UnPause();
        }
    }
    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.Pause();
        }
    }
    public void CustomSpeedPlay()
    {
        isPaused = false;
        Time.timeScale = customSpeed;
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.UnPause();
        }
    }
    public void x2Play()
    {
        isPaused = false;
        Time.timeScale = 2f;
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.UnPause();
        }
    }
    public void x4Play()
    {
        isPaused = false;
        Time.timeScale = 4f;
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.UnPause();
        }
    }
    public void x10Play()
    {
        isPaused = false;
        Time.timeScale = 10f;
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.UnPause();
        }
    }

}

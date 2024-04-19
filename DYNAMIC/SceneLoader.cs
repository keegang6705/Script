//code type : 2D,3D
//code version : 1.0
//last working : unity2022.3.17f

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneToLoad;

    public void LoadSelectedScene()
    {
        SceneManager.LoadScene(sceneToLoad);
        
    }
}

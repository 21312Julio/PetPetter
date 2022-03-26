using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public string sceneName;

    // get a string with the name of a scene on project manager and change to the scene
    // on trigger
    public void GoTo()
    {
        SceneManager.LoadScene(sceneName);
    }
}

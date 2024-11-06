using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MyAwesomeSceneManager : MonoBehaviour
{

    public void LoadNextScene()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        int currentSceneIndex = activeScene.buildIndex;

        int maxScenesCountInBuild = SceneManager.sceneCountInBuildSettings; 
        int nextSceneIndexToload = (currentSceneIndex + 1)%maxScenesCountInBuild;
        SceneManager.LoadScene(nextSceneIndexToload);
    }
    

}

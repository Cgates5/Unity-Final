using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    // Public method to load the next scene
    public void LoadNextScene()
    {
        // Get the index of the next scene (assuming it's the next scene in the build settings)
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        // Load the next scene by index
        SceneManager.LoadScene(nextSceneIndex);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages the main menu UI and handles user interactions.
/// </summary>
public class MainMenuController : MonoBehaviour
{

    /// <summary>
    /// Loads the selected scene by its name.
    /// </summary>
    /// <param name="sceneName">The name of the scene to load.</param>
    public void LoadSceneByName(string sceneName)
    {
        string logMessage = $"Loading scene: \"{ sceneName.ToString() }\"";
        Debug.Log(logMessage);
        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// Quits the application. 
    /// Note: If running in the Unity Editor, it stops play mode.
    /// </summary>
    public void Quit() 
    {
        Debug.Log("Quitting application...");
        Application.Quit();

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}

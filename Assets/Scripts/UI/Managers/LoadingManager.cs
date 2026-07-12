using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MainMenu
{
    public class LoadingManager : MonoBehaviour
    {
        [Header("LOADING SCREEN")]
        [Tooltip("If this is true, the loaded scene won't load until receiving user input")]
        public bool waitForInput = true;
        public GameObject loadingMenu;
        [Tooltip("The loading bar Slider UI element in the Loading Screen")]
        public Slider loadingBar;
        public TMP_Text loadPromptText;
        public Key userPromptKey;

        void Start()
        {
            loadingBar.value = 0f;
        }

        public void LoadScene(string sceneName)
        {
            if (string.IsNullOrWhiteSpace(sceneName))
            {
                Debug.LogWarning("SceneName cannot be null. Cannot load scene.");
                return;
            }

            Debug.Log($"Loading scene: {sceneName}");
            StartCoroutine(LoadAsynchronously(sceneName));
        }

        private IEnumerator LoadAsynchronously(string sceneName)
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
            operation.allowSceneActivation = false;

            while (!operation.isDone)
            {
                float progress = Mathf.Clamp01(operation.progress / .95f);
                loadingBar.value = progress;

                if (operation.progress >= 0.9f)
                {
                    loadingBar.value = 1f;

                    if (!waitForInput)
                    {
                        operation.allowSceneActivation = true;
                    }
                    else if (IsRequiredKeyPressed())
                    {
                        if (userPromptKey == Key.None) Debug.Log($"Any button pressed."); // only debug information
                        else Debug.Log($"Button \"{ userPromptKey.ToString() }\" pressed.");

                        operation.allowSceneActivation = true;
                    }

                    loadPromptText.text = GetPromptText();
                }

                yield return null;
            }
        }

        private bool IsRequiredKeyPressed()
        {
            if (userPromptKey == Key.None)
            {
                return Keyboard.current.anyKey.wasPressedThisFrame;
            }

            return Keyboard.current[userPromptKey].wasPressedThisFrame;
        }

        private string GetPromptText()
        {
            if (userPromptKey == Key.None)
            {
                return "Press any key to continue";
            }

            return $"Press \"{ userPromptKey.ToString().ToUpper() }\" to continue";
        }
    }
}

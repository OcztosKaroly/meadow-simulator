using UnityEngine;

namespace MainMenu
{
    [ExecuteInEditMode()]
    [System.Serializable]
    public class ThemedUI : MonoBehaviour
    {

        public ThemedUIData themeController;

        protected virtual void OnSkinUI()
        {

        }

        public virtual void Awake()
        {
            OnSkinUI();
        }

        public virtual void Update()
        {
            OnSkinUI();
        }
    }
}

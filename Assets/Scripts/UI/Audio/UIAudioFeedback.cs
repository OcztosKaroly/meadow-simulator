using MainMenu;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIAudioFeedback : MonoBehaviour,
    IPointerEnterHandler,
    IPointerClickHandler
{
    [Header("AUDIO SOURCE")]
    [Tooltip("Audio manager for handling audio feedback")]
    [SerializeField] private AudioManager audioManager;

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioManager.PlayHover();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        audioManager.PlayClick();
    }
}
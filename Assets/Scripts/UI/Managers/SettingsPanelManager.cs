using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace MainMenu
{
    public class SettingsPanelManager : MonoBehaviour
    {
        [Header("PANELS")]
        [Tooltip("The UI Panel that holds the CONTROLS window tab")]
        public GameObject PanelControls;
        [Tooltip("The UI Panel that holds the VIDEO window tab")]
        public GameObject PanelVideo;
        [Tooltip("The UI Panel that holds the GAME window tab")]
        public GameObject PanelGame;
        [Tooltip("The UI Panel that holds the KEY BINDINGS window tab")]
        public GameObject PanelKeyBindings;
        [Tooltip("The UI Sub-Panel under KEY BINDINGS for MOVEMENT")]
        public GameObject PanelMovement;
        [Tooltip("The UI Sub-Panel under KEY BINDINGS for COMBAT")]
        public GameObject PanelCombat;
        [Tooltip("The UI Sub-Panel under KEY BINDINGS for GENERAL")]
        public GameObject PanelGeneral;

        // highlights in settings screen
        [Header("SETTINGS SCREEN")]
        [Tooltip("Highlight Image for when GAME Tab is selected in Settings")]
        public GameObject lineGame;
        [Tooltip("Highlight Image for when VIDEO Tab is selected in Settings")]
        public GameObject lineVideo;
        [Tooltip("Highlight Image for when CONTROLS Tab is selected in Settings")]
        public GameObject lineControls;
        [Tooltip("Highlight Image for when KEY BINDINGS Tab is selected in Settings")]
        public GameObject lineKeyBindings;
        [Tooltip("Highlight Image for when MOVEMENT Sub-Tab is selected in KEY BINDINGS")]
        public GameObject lineMovement;
        [Tooltip("Highlight Image for when COMBAT Sub-Tab is selected in KEY BINDINGS")]
        public GameObject lineCombat;
        [Tooltip("Highlight Image for when GENERAL Sub-Tab is selected in KEY BINDINGS")]
        public GameObject lineGeneral;

        void DisablePanels()
        {
            PanelControls.SetActive(false);
            PanelVideo.SetActive(false);
            PanelGame.SetActive(false);
            PanelKeyBindings.SetActive(false);

            lineGame.SetActive(false);
            lineControls.SetActive(false);
            lineVideo.SetActive(false);
            lineKeyBindings.SetActive(false);

            PanelMovement.SetActive(false);
            lineMovement.SetActive(false);
            PanelCombat.SetActive(false);
            lineCombat.SetActive(false);
            PanelGeneral.SetActive(false);
            lineGeneral.SetActive(false);
        }

        public void GamePanel()
        {
            DisablePanels();
            PanelGame.SetActive(true);
            lineGame.SetActive(true);
        }

        public void VideoPanel()
        {
            DisablePanels();
            PanelVideo.SetActive(true);
            lineVideo.SetActive(true);
        }

        public void ControlsPanel()
        {
            DisablePanels();
            PanelControls.SetActive(true);
            lineControls.SetActive(true);
        }

        public void KeyBindingsPanel()
        {
            DisablePanels();
            MovementPanel();
            PanelKeyBindings.SetActive(true);
            lineKeyBindings.SetActive(true);
        }

        public void MovementPanel()
        {
            DisablePanels();
            PanelKeyBindings.SetActive(true);
            PanelMovement.SetActive(true);
            lineMovement.SetActive(true);
        }

        public void CombatPanel()
        {
            DisablePanels();
            PanelKeyBindings.SetActive(true);
            PanelCombat.SetActive(true);
            lineCombat.SetActive(true);
        }

        public void GeneralPanel()
        {
            DisablePanels();
            PanelKeyBindings.SetActive(true);
            PanelGeneral.SetActive(true);
            lineGeneral.SetActive(true);
        }
    }
}

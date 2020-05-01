﻿using Main;
using Main.Building;
using UnityEngine;
using UnityEngine.UI;
using Utility;

namespace UI
{
    
    // goes on UI canvas. Watches for tires that are placed down.
    public class TireNameInputHandler : MonoBehaviour
    {

        public CanvasGroup tireNamingWindow;

        public BuildHandler buildHandler;
        public CameraMotionScript cameraMotionScript;
        
        private BuildTireComponent _buildTireComponent;

        public void Start()
        {
            
            CloseInputWindow();
            
        }

        public void CloseInputWindow()
        {
            
            UIUtility.DisableCanvasGroup(tireNamingWindow);
            
            SetSceneInteractable(true);
            

        }

        public void ShowInputWindow(BuildTireComponent tireComponentJustPlaced)
        {
            
            _buildTireComponent = tireComponentJustPlaced;
            
            UIUtility.EnableCanvasGroup(tireNamingWindow);

            SetSceneInteractable(false);

        }

        public void SetTireName(Text textComponent)
        {
            
            SetTireName(textComponent.text);
            
        }

        private void SetTireName(string tireName)
        {

            _buildTireComponent.tireName = tireName;
            CloseInputWindow();

        }

        private void SetSceneInteractable(bool interactable)
        {

            cameraMotionScript.interactable = interactable;
            buildHandler.interactable = interactable;

        }

    }
}
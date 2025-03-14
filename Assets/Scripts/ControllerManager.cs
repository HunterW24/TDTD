using DanielLochner.Assets.SimpleSideMenu;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ControllerManager : MonoBehaviour
{
    public Setting settings;
    public Button settingsLeave;
    public SimpleSideMenu sideMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnOpenClose(InputValue context)
    {
        if (sideMenu.CurrentState == State.Open)
        {
            sideMenu.Close();
        }
        else
        {
            sideMenu.Open();
        }
       
    }

    public void OnPauseSettings(InputValue context)
    {
        settings.Settings();
        EventSystem.current.SetSelectedGameObject(settingsLeave.gameObject);
    }
}

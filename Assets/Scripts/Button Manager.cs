using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button buttonPlay;
    public Button buttonMenuSetting;
    public Button MenuSettingExit;
    public Button buttonGameMode;
    public Button buttonGameSetting;
    public Button settingExit;
    public Button saveAndQuit;
    public Button Handle;
    public Button[] buttonTowerButtons;

    public void HandleThingy()
    {
        EventSystem.current.SetSelectedGameObject(Handle.gameObject);
    }

    public void TowerSelect()
    {
        foreach (var button in buttonTowerButtons)
        {
            if (button.isActiveAndEnabled)
            {
                EventSystem.current.SetSelectedGameObject(button.gameObject);

                return;
            }
        }
    }
    
}

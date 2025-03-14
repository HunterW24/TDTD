using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{

    public GameObject settingScreen;
    public GameObject mainMenu;
    public GameObject oBlockMenu;
    public GameObject mainMenusettings;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Settings()
    {
        Time.timeScale = 0;
        settingScreen.SetActive(true);
    }

    public void SettingLeave()
    {
        Time.timeScale = 1;
        settingScreen.SetActive(false);

       /* if (mainMenu.activeInHierarchy == true)
        {
            Time.timeScale = 0;
        }

        if (oBlockMenu.activeInHierarchy == true)
        {
            Time.timeScale = 0;
        }*/
    }

    public void menuSettings()
    {
        Time.timeScale = 0;
       mainMenusettings.SetActive(true);
    }


    public void MenusettingsLeave()
    {
        Time.timeScale = 0;
        mainMenusettings.SetActive(false);

        /* if (mainMenu.activeInHierarchy == true)
         {
             Time.timeScale = 0;
         }

         if (oBlockMenu.activeInHierarchy == true)
         {
             Time.timeScale = 0;
         }*/
    }
}

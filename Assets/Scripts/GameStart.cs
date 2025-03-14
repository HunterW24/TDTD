using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

    public static GameObject gameStartScreen;
    // Start is called before the first frame update
    void Start()
    {
        gameStartScreen = GameObject.FindWithTag("Start");

        if (gameStartScreen.activeInHierarchy == true)
        {
            Time.timeScale = 0;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    public void StartGame()
    {
        gameStartScreen.SetActive(false);
        Time.timeScale = 1;
    }
}

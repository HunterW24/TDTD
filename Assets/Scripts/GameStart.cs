using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

    public static GameObject gameStartScreen;
    public GameObject[] disableOnStart;
    public GameObject[] enableOnStart;
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
        foreach(GameObject go in disableOnStart)
        {
            go.SetActive(false);
        }

        foreach (GameObject go in enableOnStart)
        {
            go.SetActive(true);
        }
        Time.timeScale = 1;
    }
}

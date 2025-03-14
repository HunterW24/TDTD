using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject gameOverScreen;
    public GameObject resetScore;
   
    void Start()
    {
     
    }

    void Update()
    {
        if (Health.health <= 0 && gameOverScreen.activeInHierarchy == false)
        {
            gameOverScreen.SetActive(true);
            resetScore.SetActive(false);
            Time.timeScale = 0;
        }
    }

    
}

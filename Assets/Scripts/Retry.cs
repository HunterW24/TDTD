using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject gameStartScreen;

    private void Start()
    {
        gameStartScreen = GameObject.FindWithTag("Start");
    }
    /*public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reloads the game w/the Main Menu
        gameStartScreen.SetActive(false);
        Time.timeScale = 1;
    }
    */

    public void Fullrestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reloads Game to the Main Menu
        Time.timeScale = 0;
    }

}

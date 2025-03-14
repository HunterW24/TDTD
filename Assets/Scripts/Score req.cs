using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scorereq : MonoBehaviour
{
    public int points;
    public Button button;
    public bool isButtonEnabled = false;

    void Update()
    {
        // Update score as needed

        isButtonEnabled = ScoreManager.points > points;
        button.interactable = isButtonEnabled;
    }

    public void Taxes()
    {
        ScoreManager.points -= points;
    }
}

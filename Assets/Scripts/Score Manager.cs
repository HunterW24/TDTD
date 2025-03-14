using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI pointsText;
    

    public static int score = 0;
    public static int highscore = 0;
    public static int points = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
        points = 0;

        scoreText.text = "Score: " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString(); 
        pointsText.text = "Points: " + points.ToString();

        highscore = PlayerPrefs.GetInt("highscore", highscore);

        highscoreText.text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString();
        pointsText.text = "Points: " + points.ToString();

        if (score > highscore)
        {
            highscore = score;
            highscoreText.text = "Highscore: " + score;

            PlayerPrefs.SetInt("highscore", highscore);
        }

      
       
    }

    


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "shot")
        {
            score++;
            highscore++;
            points++;
        }
    }

    public void ResetHighscore()
    {
        highscore = 0;
        PlayerPrefs.SetInt("highscore", highscore);
        highscoreText.text = "Highscore: " + highscore.ToString();
    }
}

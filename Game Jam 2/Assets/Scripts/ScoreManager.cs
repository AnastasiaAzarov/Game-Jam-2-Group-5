using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    public TMP_Text score;
    public TMP_Text highscore;

    int scoreVal = 0;
    int highscoreVal = 0;

    private void Awake() { instance = this; }

    void Start()
    {
        highscoreVal = PlayerPrefs.GetInt("highscore", 0);

        score.text = "SCORE: " + scoreVal.ToString();
        highscore.text = "HIGHSCORE: " + highscoreVal.ToString();
    }

    public void AddScore(int points) {
        scoreVal += points;
        score.text = "SCORE: " + scoreVal.ToString();

        if (highscoreVal < scoreVal)
        {
            PlayerPrefs.SetInt("highscore", scoreVal);
        }
    }
}

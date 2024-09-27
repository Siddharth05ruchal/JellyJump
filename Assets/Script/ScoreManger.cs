using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour
{
    public static ScoreManger instance;

    public Text scoreText;
    public Text highScoreText;

    int score = 0;
    int highscore = 0;

    public void Awake() { 
        instance = this;
    }
    void Start()
    {
        scoreText.text = score.ToString() + " SCORE ";
        highScoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoints() 
    {
        score += 1;
        scoreText.text = score.ToString() + " SCORE ";
    }
}

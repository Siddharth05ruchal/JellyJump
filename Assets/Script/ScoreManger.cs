using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour
{
    public static ScoreManger instance;

    public Text scoreText;
    public Text coinText;
    public Text highScoreText;

    public int score = 0;
    public int coins = 0;
    public int highscore = 0;

    public void Awake() { 
        instance = this;
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        coins = PlayerPrefs.GetInt("coins", 0);
        scoreText.text = score.ToString() + " SCORE ";
        highScoreText.text = "HIGHSCORE: " + highscore.ToString();
        coinText.text = "COINS: " + coins.ToString();
    }

    private void Update()
    {
        score = (int)Time.time;
        scoreText.text = score.ToString() + " SCORE ";
    }

    public void AddCoins() 
    {
        coins += 1;
        coinText.text = coins.ToString() + " COINS ";
        PlayerPrefs.SetInt("coins", coins);
    }


}

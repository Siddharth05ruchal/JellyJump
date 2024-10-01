using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{
    public static UIManger instance;

    [Header("Main Menu Variables")]
    public GameObject mainMenuPanel;

    public Button startGameBtn;
    public Button shopBtn;

    [Header("Score Variables")]
    public GameObject scorePanel;
    public Text scoreText;
    public Text coinText;
    public Text highScoreText;

    [HideInInspector]
    public int score = 0;
    [HideInInspector]
    public int coins = 0;
    [HideInInspector]
    public int highscore = 0;

    public void Awake() { 
        instance = this;
    }
    void Start()
    {
        mainMenuPanel.SetActive(true);
        scorePanel.SetActive(false);

        startGameBtn.onClick.AddListener(() =>
        {
            mainMenuPanel.SetActive(false);
            scorePanel.SetActive(true);
            GameManager.Instance.startGame = true;
        });

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

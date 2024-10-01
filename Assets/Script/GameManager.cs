using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool startGame = false;

    private void Awake()
    {
        Instance = this;
    }

    public void RestartGame(GameObject _player)
    {
        startGame = false;
        Destroy(_player);
        Debug.Log("Game Over");
        if (UIManger.instance.highscore < UIManger.instance.score)
        {
            PlayerPrefs.SetInt("highscore", UIManger.instance.score);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

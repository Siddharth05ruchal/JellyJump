using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour

{
    public float speed;
    public float moveDistance;
    public bool movingright = true;

    private float startPositionX;

    private void Start()
    {
        startPositionX = transform.position.x;
    }

    private void Update()
    {
        MoveLeftAndRight();
    }
    private void MoveLeftAndRight() {
        if (movingright)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= startPositionX + moveDistance)
            {
                movingright = false;
            }
        }
        else {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= startPositionX - moveDistance) { 
                movingright=true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            DestroyPlayer(collision.gameObject);
        }
    }
    public void DestroyPlayer(GameObject Player) 
    {
        Destroy(Player);
        Debug.Log("Game Over");
        if(ScoreManger.instance.highscore < ScoreManger.instance.score)
        {
            PlayerPrefs.SetInt("highscore", ScoreManger.instance.score);
        }
        Invoke("RestartGame",2f);
    }
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour

{
    public float speed = 3.5f; 

    private void Update()
    {
        if (GameManager.Instance.startGame)
        {
            MoveDown(); 
        }
    }

    private void MoveDown()
    {
        
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.RestartGame(collision.gameObject); 
        }
    }
}

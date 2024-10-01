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
        if (GameManager.Instance.startGame)
        {
            MoveLeftAndRight();
        }
    }
    private void MoveLeftAndRight() {
        if (movingright)
        {
            transform.Translate(new Vector2(1,-1) * speed * Time.deltaTime);
            
            if (transform.position.x >= startPositionX + moveDistance)
            {
                movingright = false;
            }
        }
        else {
            transform.Translate(new Vector2(-1, -1) * speed * Time.deltaTime);
            
            if (transform.position.x <= startPositionX - moveDistance) { 
                movingright=true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            GameManager.Instance.RestartGame(collision.gameObject);
        }
    }
}

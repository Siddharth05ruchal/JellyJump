using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheetosController : MonoBehaviour
{
    public float speed = 0.5f; 
    public float arcHeight = 2f; 
    public float frequency = 2f; 
    private Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if (GameManager.Instance.startGame)
        {
            Movearc(); 
        }
    }

    private void Movearc()
    {
        
        float newX = startPosition.x + speed * Time.time; 
        float newY = startPosition.y + Mathf.Sin(frequency * Time.time) * arcHeight;


        transform.position = new Vector2(newX, newY);

      
        if (transform.position.x > startPosition.x + 10f) 
        {
            transform.position = startPosition; 
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


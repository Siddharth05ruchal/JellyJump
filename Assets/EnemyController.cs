using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
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
        Invoke("RestartGame",2f);
    }
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

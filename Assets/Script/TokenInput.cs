using UnityEngine;

public class TokenInput : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Add points to the score
            UIManger.instance.AddCoins();

            // Destroy the coin
            Destroy(gameObject);
        }
    }
}

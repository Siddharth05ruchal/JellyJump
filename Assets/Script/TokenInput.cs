using UnityEngine;

public class TokenInput : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Add points to the score
            ScoreManger.instance.AddPoints();

            // Destroy the coin
            Destroy(gameObject);
        }
    }
}

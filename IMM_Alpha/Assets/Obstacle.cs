using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameOverManager gameOverManager;

    void Start()
    {
        // Find the GameOverManager in the scene
        gameOverManager = FindObjectOfType<GameOverManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Ensure the car is tagged "Player"
        {
            gameOverManager.GameOver(); // Call GameOver from the manager
        }
    }
}

using UnityEngine;

public class Point : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add logic to update the score
            Debug.Log("Point Collected!");
            Destroy(gameObject);
        }
    }
}

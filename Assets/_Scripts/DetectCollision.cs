using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public TextMeshProUGUI playerScore;
    public void StopGame()
    {
        Time.timeScale = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);

            // Met à jour le score en utilisant le script Score
            Score scoreScript = FindObjectOfType<Score>();

            if (scoreScript != null)
            {
                scoreScript.IncrementScore();
            }
            else
            {
                Debug.LogError("Le script Score n'a pas été trouvé.");
            }
        }
        if (other.CompareTag("Floor"))
        {
            Destroy(gameObject);
            StopGame();
        }
    }
}

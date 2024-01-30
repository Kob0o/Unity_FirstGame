using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    private int currentScore = 0;

    void Start()
    {
        if (playerScoreText == null)
        {
            Debug.LogError("Veuillez assigner le composant TextMeshProUGUI pour le score dans l'éditeur Unity.");
        }
    }

    public void IncrementScore()
    {
        currentScore++;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (playerScoreText != null)
        {
            playerScoreText.text = "Score : " + currentScore.ToString();
        }
    }
}

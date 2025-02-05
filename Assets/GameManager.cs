using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    private int totalCollectibles;

    void Start()
    {
        totalCollectibles = GameObject.FindGameObjectsWithTag("Collectible").Length;
        UpdateScore();
    }

    public void AddScore()
    {
        score++;
        UpdateScore();
        if (score >= totalCollectibles)
        {
            scoreText.text = "You Win!";
        }
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}

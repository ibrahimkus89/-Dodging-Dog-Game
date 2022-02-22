using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver = false;
    int score = 0;

    public Text scoreText;

    private void Awake()
    {
        instance = this;
    }
   


    public void GameOver()
    {
        gameOver = true;
        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();

    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
            print(score);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    //code used:
    //https://youtu.be/VbZ9_C4-Qbo
    bool gameEnd = false;
    float initialTime;

    void Start()
    {
        gameEnd = FindObjectOfType<GameManage>().gameEnd;
        initialTime = FindObjectOfType<GameManage>().timeRemaining;
    }

    void Update()
    {
        gameEnd = FindObjectOfType<GameManage>().gameEnd;
        if (gameEnd)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        TextMeshProUGUI gameOverText = GameObject.Find("GameOver").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        //load game over screen
        if (FindObjectOfType<GameManage>()._playerHealth <= 0)
        {
            gameOverText.text = "GAME OVER";
        }
        else if (FindObjectOfType<GameManage>().timeRemaining <= 0)
        {
            gameOverText.text = "TIME'S UP";
        }
        scoreText.text = "Score: " + FindObjectOfType<GameManage>()._playerScore.ToString();
        Debug.Log("Score: " + FindObjectOfType<GameManage>()._playerScore.ToString());
    }


    public void backToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        FindObjectOfType<GameManage>().timeRemaining = initialTime;
    }
}

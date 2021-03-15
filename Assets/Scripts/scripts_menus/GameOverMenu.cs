using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    //code used:
    //https://youtu.be/VbZ9_C4-Qbo
    GameObject gameManager;
    private GameManage gameManageScript;
    bool gameEnd = false;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        gameManageScript = gameManager.GetComponent<GameManage>();
        gameEnd = gameManageScript.gameEnd;
    }

    void Update()
    {
        gameEnd = gameManageScript.gameEnd;
        Debug.Log("gameEnd (GameOverMenu) = " + gameEnd);
        if (gameEnd)
        {
            Debug.Log("game over");
            GameOver();
        }
    }

    public void GameOver()
    {
        TextMeshProUGUI gameOverText = GameObject.Find("GameOver").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        //load game over screen
        if (gameManageScript._playerHealth <= 0)
        {
            Debug.Log(gameManageScript._playerHealth);
            gameOverText.text = "GAME OVER";
        }
        else if (gameManageScript.timeRemaining <= 0)
        {
            Debug.Log("out of time");
            gameOverText.text = "TIME'S UP";
        }
        scoreText.text = "Score: " + gameManageScript._playerScore.ToString();
        Debug.Log("Score: " + gameManageScript._playerScore.ToString());
    }

    public void backToMain()
    {
        ResetGame();
        SceneManager.LoadScene("StartMenu");
    }

    public void Restart()
    {
        ResetGame();
        SceneManager.LoadScene("SampleScene");
    }

    public void ResetGame()
    {
        gameEnd = false;
        gameManageScript.timeRemaining = gameManageScript.initialTime;
        gameManageScript._playerHealth = gameManageScript.initialHealth;
        gameManageScript._playerScore = 0;
        Destroy(gameManager);
    }
}

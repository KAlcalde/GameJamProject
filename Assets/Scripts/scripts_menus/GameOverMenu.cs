using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    public void GameOver()
    {
        bool gameEnd = false;
        TextMeshProUGUI gameOverText = GameObject.Find("GameOver").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        if (!gameEnd)
        {
            gameEnd = true;
            //load game over screen
            //SceneManager.LoadScene("MainMenu");
            //GameObject.Find("MainMenu").SetActive(false);
            //GameObject.Find("GameOverMenu").SetActive(true);
            if (FindObjectOfType<PlayerHit>()._playerHealth <= 0)
            {
                gameOverText.text = "GAME OVER";
            }
            else if (!FindObjectOfType<GameTimer>().isRunning)
            {
                gameOverText.text = "TIME'S UP";
            }
            scoreText.text = "Score: " + GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>()._playerScore;
        }
    }
    public void backToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

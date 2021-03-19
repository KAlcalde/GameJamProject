using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameTimer : MonoBehaviour
{
    //code from:
    //https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/
    //https://forum.unity.com/threads/from-unity-ui-to-textmeshpro.463619/

    public float timeRemaining;
    public bool isRunning = false;
    public TextMeshProUGUI timeText;

    private void Start()
    {
        timeText = GameObject.Find("TimerText").GetComponent<TextMeshProUGUI>();
        isRunning = true;
        timeRemaining = GameObject.Find("GameManager").GetComponent<GameManage>().timeRemaining;
    }

    void Update()
    {
        if (isRunning)
        {
            if (timeRemaining > 0)
            {
                DisplayTime(timeRemaining);
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("time's up");
                timeRemaining = 0;
                isRunning = false;
                SceneManager.LoadScene("GameOverMenu");
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1f;

        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt((timeRemaining % 60));

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

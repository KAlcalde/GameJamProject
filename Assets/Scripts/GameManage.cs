using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    public float _playerScore = 0;
    public int _playerHealth;
    public float timeRemaining;
    public float initialTime;
    public int initialHealth;
    public bool gameEnd;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        initialTime = timeRemaining;
        initialHealth = _playerHealth;
        gameEnd = false;
        DontDestroyOnLoad(GameObject.Find("GameManager"));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("initial time = " + initialTime);
        if (_playerHealth <= 0 || timeRemaining <= 0)
        {
            gameEnd = true;
            //Debug.Log("gameEnd (GameManage) = " + gameEnd);
        }
        else
        {
            player = GameObject.Find("Player");
            //Debug.Log("player =  " + player);
            _playerHealth = player.GetComponent<PlayerHit>()._playerHealth;
            _playerScore = player.GetComponent<PlayerMovement>()._playerScore;
            timeRemaining = GameObject.Find("TimerText").GetComponent<GameTimer>().timeRemaining;
            //Debug.Log("timeRemaining (GameManage) = " + timeRemaining);
        }
    }
}

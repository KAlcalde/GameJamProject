using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    public int _playerScore = 0;
    public int _playerHealth;
    public float timeRemaining;
    public bool gameEnd;
    //public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        gameEnd = false;
        DontDestroyOnLoad(GameObject.Find("GameManager"));
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerHealth <= 0 || timeRemaining <= 0)
        {
            gameEnd = true;
        }
        else
        {
            //player = GameObject.Find("Player");
            //Debug.Log("player =  " + player);
            //_playerHealth = GameObject.Find("Player").GetComponent<PlayerHit>()._playerHealth;
            timeRemaining = GameObject.Find("Timer").GetComponent<GameTimer>().timeRemaining;
        }
    }
}

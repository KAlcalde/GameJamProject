using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    public int _playerHealth;
    public GameManage gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManage>();
        _playerHealth = gameManager._playerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("player health = " + _playerHealth);
        if (_playerHealth <= 0)
        {
            //game over
            Debug.Log("game over");
            SceneManager.LoadScene("GameOverMenu");
            //FindObjectOfType<MainMenu>().GameOver();
            //GameObject.Find("MainMenu").SetActive(false);
            //GameObject.Find("GameOverMenu").SetActive(true);
        }
    }

    void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.tag == "enemyBullet")
        {
            _playerHealth--;
            Debug.Log("hit");
            other.gameObject.SetActive(false);
        }
    }
}

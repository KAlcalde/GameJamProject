using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    public int _playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _playerHealth = GameObject.Find("GameManager").GetComponent<GameManage>()._playerHealth;
        //Debug.Log("player health = " + _playerHealth);
        if (_playerHealth <= 0)
        {
            //game over
            Debug.Log("game over");
            SceneManager.LoadScene("GameOverMenu");
        }
    }

    void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.tag == "enemyBullet")
        {
            GameObject.Find("GameManager").GetComponent<GameManage>()._playerHealth--;
            Debug.Log("hit");
            Debug.Log("health: " + _playerHealth);
            other.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public float _playerHealth = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("player health = " + _playerHealth);
        if (_playerHealth <= 0)
        {
            //game over
            Debug.Log("game over");
        }
    }

    void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.tag == "enemyBullet")
        {
            _playerHealth--;
            other.gameObject.SetActive(false);
        }
        //if (_playerHealth <= 0)
        //{
        //    //game over
        //    Debug.Log("player health = 0");
        //    //player.SetActive(false);
        //}
    }
}

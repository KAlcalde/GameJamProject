using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float playerBulletSpeed = 5f;

    public PlayerMovement playerIncrease;
    public GameObject playerObject;

    void Awake()
    {
        GameObject playerObject = GameObject.Find("Player");
        playerIncrease = playerObject.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        transform.Translate(Vector3.up * playerBulletSpeed * Time.deltaTime);

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            playerIncrease.AddScore(500f);
        }
        else if (collision.gameObject.tag == "enemyBase")
        {
            playerIncrease.AddScore(2000f);
        }
        
        Destroy(this);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public int enemyHealth = 1;
    public GameObject EnemyRespawn;

    // Start is called before the first frame update
    void Start()
    {
        EnemyRespawn = GameObject.Find("EnemyRespawn");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "playerBullet")
        {
            enemyHealth--;
            Destroy(other.gameObject);
        }
        if (enemyHealth <= 0)
        {
            this.gameObject.SetActive(false);
            enemyHealth++;
        }
    }
}

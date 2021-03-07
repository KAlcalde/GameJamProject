using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBMove : MonoBehaviour
{
    //code from:
    //https://answers.unity.com/questions/1443647/random-rotation-with-limited-range.html

    /* 
     * Notes:
     * spawn these from the sides of the play area
     * spawns at a random angle within a set range and moves forward until it leaves the play area
     */

    public float speed = 5f;
    public float startDelay = 3f;
    public float turnInterval = 1.75f;
    Quaternion startOrientation;
    Quaternion newDirection;
    // Start is called before the first frame update
    void Awake()
    {
        startOrientation = Quaternion.Euler(0,Random.Range(-60f, 60f),0);
        InvokeRepeating("changeDirection", startDelay, turnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void changeDirection()
    {
        newDirection = Quaternion.Euler(0, Random.Range(-90f, 90f), 0);
    }
}

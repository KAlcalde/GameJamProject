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
     * spawns at a random angle within a set range and moves forward
     * randomly changes directions at set intervals
     */

    public float speed = 5f;
    public float startDelay = 3f;
    public float turnInterval = 1.75f;
    Quaternion startOrientation;
    Quaternion newOrientation;
    // Start is called before the first frame update
    void Awake()
    {
        startOrientation = Quaternion.Euler(0,Random.Range(-60f, 60f),0);
        transform.rotation = startOrientation;
        InvokeRepeating("changeDirection", startDelay, turnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void changeDirection()
    {
        newOrientation = Quaternion.Euler(0, Random.Range(0f, 360f), 0);
        transform.rotation = newOrientation;
    }
}

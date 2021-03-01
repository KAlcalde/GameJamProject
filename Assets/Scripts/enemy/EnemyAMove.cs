using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAMove : MonoBehaviour
{
    /*
     * Notes:
     * spawn these from the top and/or the sides of the play area
     * moves in a straight line and stops when it reaches a set point
     */

    public float speed;
    //public GameObject endPoint;
    Vector3 endPos;
    GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = gameObject;
        endPos.x = Random.Range(-17f,17f);
        endPos.y = transform.position.y;
        endPos.z = Random.Range(9f, 14f); //filler code for testing
        //endPos = //use for actual end position
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,endPos,0.01f);
    }
}

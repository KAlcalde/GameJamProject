using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    /*
     * Notes:
     * instantiates bullets from pool
     */

    //code from:
    //https://learn.unity.com/tutorial/introduction-to-object-pooling (object pooling)
    //https://stackoverflow.com/a/40752191 (GetChild)
    
    GameObject enemyPointer; //object marking origin of bullets
    Vector3 pointerPos; //enemyPointer position

    GameObject bullet; //bullet
    public float bulletSpeed = 10f; //speed of bullet

    public float startDelay = 1.2f; //time between enemy spawning and enemy shooting
    public float shootInterval = 1.2f; //time between shots

    // Start is called before the first frame update
    void Awake()
    {
        //begins recurring shooting
        InvokeRepeating("shoot", startDelay, shootInterval);
    }

    // Update is called once per frame
    void shoot()
    {
        //defining these from other objects
        enemyPointer = gameObject.transform.GetChild(0).gameObject; //gets child of enemy/gameObject by index
        //Debug.Log("enemyPointer = " + enemyPointer); //prints object assigned to enemyPointer
        pointerPos = enemyPointer.transform.position; //gets position of pointer
        bullet = ObjectPool.SharedInstance.GetPooledObject(); //gets bullet from pool
        //Debug.Log("bullet = " + bullet); //verify that bullet was gotten from correct pool
        if (bullet != null)
        {
            bullet.transform.position = pointerPos; //sets bullet position to position of enemy pointer
            bullet.transform.rotation = enemyPointer.transform.rotation;
            bullet.transform.Rotate(90, 0, 0);
            bullet.SetActive(true); //spawns a bullet from the pool
        }
    }
}

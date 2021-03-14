using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsDestroy : MonoBehaviour
{
    /* 
     * Notes:
     * deactivates objects that collide with defined boundaries
     * reverses direction of enemies that collide with defined boundaries
     */

    //code from:
    //https://answers.unity.com/questions/476128/how-to-change-quaternion-by-180-degrees.html

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            other.transform.rotation *= Quaternion.Euler(0, 180f, 0);
        }
        else if(other.gameObject.tag == "enemyBullet")
        {
            other.gameObject.SetActive(false);
        }
        Debug.Log("Collided with " + other.gameObject);
        
    }
}

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Player")
        {
            other.gameObject.SetActive(false);
        }
        //Debug.Log("Collided with " + other.gameObject);
        
    }
}

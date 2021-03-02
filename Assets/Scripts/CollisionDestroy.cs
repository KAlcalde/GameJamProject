using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    /* 
     * Notes:
     * deactivates gameObject on collision
     */

    void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
    }
}

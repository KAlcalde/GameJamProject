using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float playerBulletSpeed = 5f;

    

    private void Update()
    {
        transform.Translate(Vector3.forward * playerBulletSpeed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this);
    }
}

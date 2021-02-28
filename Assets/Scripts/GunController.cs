using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public bool isFiring;

    public BulletController bullet;
    [SerializeField] private float _bulletSpeed;

    public float timeBetweenShots;
    public float shotCounter;

    public Transform bulletSpawnPoint;

    

    // Update is called once per frame
    void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;

                BulletController newBullet = Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation) as BulletController;
                newBullet.playerBulletSpeed = _bulletSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
    }

  
}

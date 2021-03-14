using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _playerSpeed = 10f;

    //public float _playerHealth = 20f;

    //public float _playerScore = 0;
    
    public GunController gun;
    private void Awake()
    {
        
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        transform.position += movement * Time.deltaTime * _playerSpeed * -1;
        if (Input.GetMouseButtonDown(0))
        {
            gun.isFiring = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            gun.isFiring = false;
        }
    }
}

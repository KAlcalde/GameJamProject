using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    private Camera _cam;
   
    public Rigidbody rb;

    private void Start()
    {
        _cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Ray camRay = _cam.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if(groundPlane.Raycast(camRay, out rayLength))
        {
            Vector3 pointToLook = camRay.GetPoint(rayLength);

            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }

   
}

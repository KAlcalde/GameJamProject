using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform cameraLookAt;

    public float boundX = 2.0f;
    public float boundZ = 1.5f;

    public float lerpSpeed = 0.15f;

    private Vector3 desiredPosition;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        float dx = cameraLookAt.position.x - transform.position.x;
        if(dx > boundX || dx < -boundX)
        {
            if (transform.position.x < cameraLookAt.position.x)
            {
                delta.x = dx - boundX;
            }
            else
            {
                delta.x = dx + boundX;
            }
        }

        float dz = cameraLookAt.position.z - transform.position.z;
        if (dz > boundZ || dz < -boundZ)
        {
            if (transform.position.z < cameraLookAt.position.z)
            {
                delta.z = dz - boundZ;
            }
            else
            {
                delta.z = dz + boundZ;
            }
        }

        //Move the camera
        desiredPosition= transform.position + delta;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, lerpSpeed);
    }
}

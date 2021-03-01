using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsDestroy : MonoBehaviour
{
    /* 
     * Notes:
     * deactivates objects that collide with defined boundaries
     * place boundaries outside spawn area(s) so stuff doesn't just get destroyed immediately
     */

    //values for z-/x-coordinates of boundaries; adjust as necessary
    private float boundaryN;
    private float boundaryS;
    private float boundaryW;
    private float boundaryE;

    // Start is called before the first frame update
    void Start()
    {
        boundaryN = GameObject.Find("boundaryN").transform.position.z; //z-coordinate of top boundary
        boundaryS = GameObject.Find("boundaryS").transform.position.z; //z-coordinate of bottom boundary
        boundaryW = GameObject.Find("boundaryW").transform.position.x; //x-coordinate of left boundary
        boundaryE = GameObject.Find("boundaryE").transform.position.x; //x-coordinate of right boundary
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < boundaryW || transform.position.x > boundaryE)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.z < boundaryS || transform.position.z > boundaryN)
        {
            gameObject.SetActive(false);
        }
    }
}

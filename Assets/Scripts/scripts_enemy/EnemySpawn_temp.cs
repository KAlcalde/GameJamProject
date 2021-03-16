using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn_temp : MonoBehaviour
{
    public GameObject enemy;
    public Vector3 spawnPos;
    public Quaternion spawnRot;

    public GameObject boundaryN;
    public GameObject boundaryS;
    public GameObject boundaryW;
    public GameObject boundaryE;

    public float boundXMin;
    public float boundXMax;
    public float boundYMin;
    public float boundYMax;

    // Start is called before the first frame update
    void Start()
    {
        boundaryN = GameObject.Find("Boundary_Top");
        boundaryS = GameObject.Find("Boundary_Bottom");
        boundaryW = GameObject.Find("Boundary_Left");
        boundaryE = GameObject.Find("Boundary_Right");

        boundXMin = -boundaryW.transform.position.x;
        boundXMax = -boundaryE.transform.position.x;
        boundYMin = -boundaryS.transform.position.z;
        boundYMax = -boundaryN.transform.position.z;
        
        SetSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(!enemy.activeInHierarchy)
        {
            SetSpawn();
            enemy.SetActive(true);
        }
    }

    void SetSpawn()
    {
        spawnPos = new Vector3(Random.Range(boundXMin + 20f, boundXMax - 20f), 3f, Random.Range(boundYMin + 20f, boundYMax - 20f));
        //Debug.Log((boundXMin + 20f) + ", " + (boundXMax - 20f));
        spawnRot = Quaternion.Euler(0, Random.Range(0f, 360f), 0);
        enemy.transform.position = spawnPos;
        enemy.transform.rotation = spawnRot;
        //Debug.Log(enemy + " position = " + enemy.transform.position);
    }
}

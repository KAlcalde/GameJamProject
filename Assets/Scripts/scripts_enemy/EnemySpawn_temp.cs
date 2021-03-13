using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn_temp : MonoBehaviour
{
    public GameObject enemy;
    public Vector3 spawnPos;
    public Quaternion spawnRot;

    // Start is called before the first frame update
    void Start()
    {
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
        spawnPos = new Vector3(Random.Range(-100f, 100f), 3f, Random.Range(-100f, 100f));
        spawnRot = Quaternion.Euler(0, Random.Range(0f, 360f), 0);
        enemy.transform.position = spawnPos;
        enemy.transform.rotation = spawnRot;
        Debug.Log(enemy + " position = " + enemy.transform.position);
    }
}

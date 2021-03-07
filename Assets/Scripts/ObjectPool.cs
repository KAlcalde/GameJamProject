using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code from:
//https://learn.unity.com/tutorial/introduction-to-object-pooling

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;
    private int pooled;

    void Awake()
    {
        SharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        //Debug.Log("(Start) amountToPool = " + amountToPool);
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);;
        }
        //Debug.Log(objectToPool + ": " + pooledObjects.Count + " pooled");
    }

    public GameObject GetPooledObject()
    {
        //Debug.Log("(GetPooledObject) amountToPool = " + amountToPool);
        //Debug.Log(objectToPool + ": " + pooledObjects.Count + " pooled");
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
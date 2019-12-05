using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectPoolItems
{

    public GameObject objectToPool;
    public int poolSize = 10;
    public bool shouldIncreaseSize = true;

}

public class BulletPool : MonoBehaviour
{
    public static BulletPool sharedInstance;
    public List<GameObject> objectsInPool;
    public List<ObjectPoolItems> objectsToAdd;
    private void Awake()
    {

        sharedInstance = this;
        InstantiatePool();

    }
    //gets the objects in the pool currently and checks to see if they are active in hierarchy and if they have the tag specific in the spawners
    public GameObject GetObjectPool(string tag)
    {

        for (int i = 0; i < objectsInPool.Count; i++)
        {

            if (!objectsInPool[i].activeInHierarchy && objectsInPool[i].tag == tag)
            {

                return objectsInPool[i];

            }

        }

        foreach (ObjectPoolItems item in objectsToAdd)
        {

            if (item.objectToPool.tag == tag)
            {
                //double checks to see if the object it is currently on has the bool for increasing the size of the pool to true, if not then doesn't do anything
                if (item.shouldIncreaseSize)
                {

                    GameObject poolObject = (GameObject)Instantiate(item.objectToPool);
                    poolObject.SetActive(false);
                    objectsInPool.Add(poolObject);
                    return poolObject;

                }
            }

        }
        return null;

    }
    //instantiates the pool, this is used on start and again if the pool is empty.
    void InstantiatePool()
    {

        objectsInPool = new List<GameObject>();
        foreach (ObjectPoolItems item in objectsToAdd)
        {

            for (int i = 0; i < item.poolSize; i++)
            {

                GameObject poolObject = (GameObject)Instantiate(item.objectToPool);
                poolObject.SetActive(false);
                objectsInPool.Add(poolObject);

            }

        }

    }
}

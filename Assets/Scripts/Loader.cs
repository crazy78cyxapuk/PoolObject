using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject prefab;
    public List<GameObject> objs = new List<GameObject>();

    private ManagerPool managerPool = new ManagerPool();


    void Awake()
    {
        managerPool.AddPool(PoolType.Entities);

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            for (var i = 0; i < 1; i++)
            {
                objs.Add(managerPool.Spawn(PoolType.Entities, prefab));
            }

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            for (var i = 0; i < objs.Count; i++)
            {
                managerPool.Despawn(PoolType.Entities, objs[i]);
            }
            objs.Clear();
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Vector3[] spawn;
    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= enemy.Length - 1; i++)
        {
            spawn[i] = enemy[i].transform.position;
            print(spawn[i]);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}

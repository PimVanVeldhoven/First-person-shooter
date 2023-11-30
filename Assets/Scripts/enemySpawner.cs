using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject normalEnemy;
    public int enemyMax;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < enemyMax; i++)
        {
            GameObject enemy = Instantiate(normalEnemy, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

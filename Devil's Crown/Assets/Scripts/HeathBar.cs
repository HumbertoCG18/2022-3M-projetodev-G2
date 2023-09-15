using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManeger : MonoBehaviour{
    [SerializeField] Transform[] SpawnPoints;
    [SerializeField] GameObject Enemy;

    void Start(){
        InvokeRepeating("SpawnEmenies", 0.5f, 0.5f);
    }


    void SpawnEnemies(){
        int index = Random.Range(0, SpawnPoints.Length);
        Instantiate(Enemy, SpawnPoints[index].position, Quaternion.identity);
    }
}

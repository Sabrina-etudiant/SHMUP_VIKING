using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class aleatoireSpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] EnnemyTestPrefabTest;
    public float repetition;
    public float attente;
    void Start()
    {
        InvokeRepeating("Spawn", attente, repetition);
    }
    void Update()
    {
      //  InvokeRepeating("Spawn",10, repetition);
    }


    public void Spawn()

    {

        Debug.Log("Spawn");
            int randEnnemy = Random.Range(0, EnnemyTestPrefabTest.Length);
            int randspawnPoint = Random.Range(0, spawnPoint.Length);

            Instantiate(EnnemyTestPrefabTest[randEnnemy], spawnPoint [randspawnPoint].position , transform.rotation);
        
    }
}

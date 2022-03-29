using System;
using UnityEngine.InputSystem;
using UnityEngine;
using System.Collections;

public class SpawnEnemyControl : MonoBehaviour
{
    public Transform[] firePoint;
    public GameObject[] enemyProjectile;
    
    public GameObject explosionPrefab;
    
    private Rigidbody2D rb;
    
    [SerializeField] private float cooldown;
    
    private  float lastShoot;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("player2");
    }

    private void Update()
    {
        
    }

    public void OnShoot(InputValue value)
    {
        if (value.isPressed)
        {
            Instantiate(enemyProjectile[0], firePoint[0].position, firePoint[0].rotation);
        }
    }

    public void OnChien(InputValue value) //press Numpad C
    {
        if (value.isPressed)
        {
            Instantiate(enemyProjectile[1], firePoint[1].position, firePoint[1].rotation);
            return;
        }
        Debug.Log(enemyProjectile);
    }
    
    public void OnEnnemi1(InputValue value) //press Numpad E
    {
        if (value.isPressed)
        {
            Instantiate(enemyProjectile[2], firePoint[2].position, firePoint[2].rotation);
            return;
        }
    }
    
    public void OnGeant(InputValue value) //press Numpad G
    {
        if (value.isPressed)
        {
            Instantiate(enemyProjectile[3], firePoint[3].position, firePoint[3].rotation);
            return;
        }
    }
    
    public void OnSerpent(InputValue value) //press Numpad S
    {
        if (value.isPressed)
        {
            Instantiate(enemyProjectile[4], firePoint[4].position, firePoint[4].rotation);
            return;
        }
    }
    
    public void OnExplosion(InputValue value) //press Numpad X
    {
        if (value.isPressed)
        {
            Instantiate(enemyProjectile[5], firePoint[5].position, firePoint[5].rotation);
            return;
        }
    }
    
/*
    public void enemy(GameObject enemyProjectile, Transform firePoint, float cooldown)
    {
        Instantiate(enemyProjectile, firePoint.transform.position, firePoint.transform.rotation);
        
        
        if (Time.time <= lastShoot + cooldown)
        {
            Instantiate(enemyProjectile, firePoint.position, firePoint.rotation);
        }
        lastShoot = Time.time;
    }
    */

    public void DogCapacity(InputAction.CallbackContext context)
    {
        //Appeler le script

        foreach (var gameObj in GameObject.FindGameObjectsWithTag("Dog"))
        {
            Instantiate(explosionPrefab, gameObj.transform.position, Quaternion.identity);
            Destroy(gameObj);
            Debug.Log("lol");
        }
    }
}
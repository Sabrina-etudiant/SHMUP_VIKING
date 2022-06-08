using System;
using UnityEngine.InputSystem;
using UnityEngine;
using System.Collections;

public class SpawnEnemyControl : MonoBehaviour
{
    public Transform[] firePoint;
    public GameObject Dog;
    public GameObject Snake;
    public GameObject Giant;
    public GameObject Draugr;
    public GameObject explosionPrefab;
    private Rigidbody2D rb;
    public float cooldown;
    float lastShoot;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("player2");
    }

  /*  public void OnShoot(InputValue value)
    {
        if (value.isPressed)
        {
            Instantiate(, firePoint[0].position, firePoint[0].rotation);
        }
    }*/

    public void OnDog(InputValue value) //press Numpad C
    {
        if (value.isPressed)
        {
            if (Time.time - lastShoot < cooldown)
                return;
            lastShoot = Time.time;
            Instantiate(Dog, firePoint[1].position, firePoint[1].rotation);
            Debug.Log("Dog");
            return;
        }
    }

    public void OnSnake(InputValue value) //press Numpad E
    {
        if (value.isPressed)
        {
            if (Time.time - lastShoot < cooldown)
                return;
            lastShoot = Time.time;
            Instantiate(Snake, firePoint[2].position, firePoint[2].rotation);
            Debug.Log("Snake");
            return;
        }
    }

    public void OnGiant(InputValue value) //press Numpad G
    {
        if (value.isPressed)
        {
            if (Time.time - lastShoot < cooldown)
                return;
            lastShoot = Time.time;
            Instantiate(Giant, firePoint[3].position, firePoint[3].rotation);
            Debug.Log("Giant");
            return;
        }
    }

    public void OnDraugr(InputValue value) //press Numpad S
    {
        if (value.isPressed)
        {
            if (Time.time - lastShoot < cooldown)
                return;
            lastShoot = Time.time;
            Instantiate(Draugr, firePoint[4].position, firePoint[4].rotation);
            Debug.Log("Draugr");
            return;
        }
    }

    public void OnExplosion(InputValue value) //press Numpad X
    {
        foreach (var gameObj in GameObject.FindGameObjectsWithTag("Dog"))
        {
            Instantiate(explosionPrefab, gameObj.transform.position, Quaternion.identity);
            Destroy(gameObj);
            Debug.Log("Explosion");
        }

    }
        void OnDogCapacity(InputValue value)
        {
            foreach (var gameObj in GameObject.FindGameObjectsWithTag("Dog"))
            {
                Instantiate(explosionPrefab, gameObj.transform.position, Quaternion.identity);
                Destroy(gameObj);
                Debug.Log("lol");
            }
        }
    }

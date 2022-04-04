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

    [SerializeField] private float cooldown;

    private float lastShoot;

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

    public void OnChien(InputValue value) //press Numpad C
    {
        if (value.isPressed)
        {
            Instantiate(Dog, firePoint[1].position, firePoint[1].rotation);
            return;
        }
    }

    public void OnEnnemi1(InputValue value) //press Numpad E
    {
        if (value.isPressed)
        {
            Instantiate(Snake, firePoint[2].position, firePoint[2].rotation);
            return;
        }
    }

    public void OnGeant(InputValue value) //press Numpad G
    {
        if (value.isPressed)
        {
            Instantiate(Giant, firePoint[3].position, firePoint[3].rotation);
            return;
        }
    }

    public void OnSerpent(InputValue value) //press Numpad S
    {
        if (value.isPressed)
        {
            Instantiate(Snake, firePoint[4].position, firePoint[4].rotation);
            return;
        }
    }

    public void OnExplosion(InputValue value) //press Numpad X
    {
        foreach (var gameObj in GameObject.FindGameObjectsWithTag("Dog"))
        {
            Instantiate(explosionPrefab, gameObj.transform.position, Quaternion.identity);
            Destroy(gameObj);
            Debug.Log("lol");
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

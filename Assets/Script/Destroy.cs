using System;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private int timeToDestroy;

    private void Start()
    {
        Destroy(this.gameObject, timeToDestroy);
    }
}

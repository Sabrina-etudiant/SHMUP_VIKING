
using UnityEngine;

public class AutoShoot : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    public float fireRate;
    public float nextFire;
    private void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }
    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        }
    }
}
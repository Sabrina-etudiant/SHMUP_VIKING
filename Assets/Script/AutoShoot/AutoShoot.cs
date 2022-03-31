
using UnityEngine;

public class AutoShoot : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    public float cooldown;
    float lastShoot;
    private void Start()
    {

    }
    void Update()
    {
        if (Time.time - lastShoot < cooldown)
            return;
        lastShoot = Time.time;
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
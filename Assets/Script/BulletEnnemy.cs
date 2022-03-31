
using UnityEngine;

public class BulletEnnemy : MonoBehaviour
{
    public Transform Point1;
    public GameObject BulletEnnemyPrefab;
    Rigidbody2D rb;
    [SerializeField] float speed;
    public float cooldown;
    float lastShoot;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    public void Shoot()
    {
        if (Time.time - lastShoot < cooldown)
            return;
        lastShoot = Time.time;
        Instantiate(BulletEnnemyPrefab, Point1.position, Point1.rotation);
    }
    void Destruct(Collider2D collider)
    {
        Destroy(gameObject);
    }

}

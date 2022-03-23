
using UnityEngine;

public class BulletEnnemy : MonoBehaviour
{
    public Transform Point1;
    public GameObject BulletEnnemyPrefab;
    Rigidbody2D rb;
    [SerializeField] float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;

    }

    
    void Update()
    {
        
    }
    public void Shoot()
    {
        Instantiate(BulletEnnemyPrefab, Point1.position, Point1.rotation);
        Shoot();
    }
 
}

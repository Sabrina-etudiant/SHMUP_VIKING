using UnityEngine;

public class ArmeAuto : MonoBehaviour
{
    public Transform Point1;
    public GameObject EnnemyPrefab;
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
        Instantiate(EnnemyPrefab, Point1.position, Point1.rotation);
        Shoot();
    }
    
}

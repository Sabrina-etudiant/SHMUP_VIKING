using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class DogCollision : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public int damage = 40;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }
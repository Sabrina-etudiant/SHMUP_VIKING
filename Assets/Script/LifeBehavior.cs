using UnityEngine;
public class LifeBehavior : MonoBehaviour
{
    public float healthAmount;
    void Start()
    {
        healthAmount = 1;
    }

    void Update()
    {
        if (healthAmount <= 0)
            Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        healthAmount -= 1;
    }
}
using UnityEngine;
public class LifeBehavior : MonoBehaviour
{
    public float healthAmount;
    [HideInInspector] public float maxHealth;
    void Start()
    {
        maxHealth = 5;
        healthAmount = maxHealth;
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
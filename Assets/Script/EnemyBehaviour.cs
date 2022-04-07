using UnityEngine;// Script agit comme un Chef d'orchestre c'est lui qui va indiquer quand (action)

public class EnemyBehaviour : MonoBehaviour
{
    public float healthAmount;
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
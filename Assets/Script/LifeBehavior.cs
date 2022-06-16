using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class LifeBehavior : MonoBehaviour
{
    public float healthAmount;
    [SerializeField] UnityEvent onOver;
    void Start()
    {
        healthAmount = 5;
    }

    void Update()
    {
        if (healthAmount <= 0)
            onOver?.Invoke();
            Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        healthAmount -= 1;
    }
}
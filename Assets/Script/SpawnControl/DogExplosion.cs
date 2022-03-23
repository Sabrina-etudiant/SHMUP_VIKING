using UnityEngine;

public class DogExplosion : MonoBehaviour
{
   
    public float destruction;
    private void Start()
    {
        Invoke("Destroy", destruction);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}


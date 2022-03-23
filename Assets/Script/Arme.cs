using UnityEngine.InputSystem;
using UnityEngine;

public class Arme : MonoBehaviour
{
    public Transform point;
    public GameObject BulletPrefab;

    void Update()
    {

    }
    
    public void OnShoot(InputValue value)
    {
        if (value.isPressed)
        {
            Instantiate(BulletPrefab, point.position, point.rotation);
        }
    }
}


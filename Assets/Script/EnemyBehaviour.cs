using UnityEngine;// Script agit comme un Chef d'orchestre c'est lui qui va indiquer quand (action)

public class EnemyBehaviour : MonoBehaviour
{
    private Shooter2D shooter;

    // Start is called before the first frame update
    private void Start()
    {
        shooter = GetComponent<Shooter2D>();//Récupération du script shoot2D 
        InvokeRepeating(nameof(Shoot), 0, 0.4f);
    }

    private void Shoot()
    {
        shooter.Shoot();
    }
}
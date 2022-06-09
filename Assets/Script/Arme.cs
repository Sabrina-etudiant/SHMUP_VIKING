using UnityEngine.InputSystem;
using UnityEngine;
using System.Collections;

public class Arme : MonoBehaviour
{
    public Transform[] point;
    public GameObject BulletPrefab;
    public float sceptreCooldown;
    public float spellCooldown;

    public bool canShoot;
    public bool canSpell;

    private void Start()
    {
        canShoot = true;
        canSpell = true;
    }

    void Update()
    {

    }
    
    public void OnShoot(InputValue value)
    {
        if (value.isPressed && canShoot == true)
        {
            Instantiate(BulletPrefab, point[0].position, point[0].rotation);
            Instantiate(BulletPrefab, point[1].position, point[1].rotation);
            StartCoroutine(sceptreFireRate());
        }
    }

    public void OnSpell(InputValue value)
    {
        if (value.isPressed && canSpell == true)
        {
            Instantiate(BulletPrefab, point[2].position, point[2].rotation);
            StartCoroutine(spellFireRate());
        }
    }

    IEnumerator sceptreFireRate()
    {
        canShoot = false;
        yield return new WaitForSeconds(sceptreCooldown);
        canShoot = true;
    }

    IEnumerator spellFireRate()
    {
        canSpell = false;
        yield return new WaitForSeconds(spellCooldown);
        canSpell = true;
    }

}


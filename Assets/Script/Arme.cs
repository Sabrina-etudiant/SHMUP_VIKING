using UnityEngine.InputSystem;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Arme : MonoBehaviour
{
    public Transform[] point;
    public GameObject BulletPrefab;
    public float sceptreCooldown;
    public float spellCooldown;
    public float MegaCooldown;
    public bool canShoot;
    public bool canSpell;
    public bool canMega;
    private void Start()
    {
        canShoot = true;
        canSpell = true;
        canMega = true; 
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
            Instantiate(BulletPrefab, point[2].position, point[2].rotation);
            StartCoroutine(sceptreFireRate());
        }
    }
    public void OnSpell(InputValue value)
    {
        if (value.isPressed && canSpell == true)
        {
            Instantiate(BulletPrefab, point[3].position, point[3].rotation);
            StartCoroutine(spellFireRate());
        }
    }
    public void OnMega(InputValue value)
    {
        if (value.isPressed && canMega == true)
        {
            Instantiate(BulletPrefab, point[4].position, point[4].rotation);
            Instantiate(BulletPrefab, point[5].position, point[5].rotation);
            Instantiate(BulletPrefab, point[6].position, point[6].rotation);
            Instantiate(BulletPrefab, point[7].position, point[7].rotation);
            StartCoroutine(sceptreMega());
        }
    }
    IEnumerator sceptreMega()
    {
        canMega = false;
        yield return new WaitForSeconds(MegaCooldown);
        canMega = true;
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
    void OnWin(InputValue value)
    {
        SceneManager.LoadScene(10);
    }
}


/*using UnityEngine.InputSystem;
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
}*/


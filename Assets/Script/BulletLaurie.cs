using UnityEngine;

public class BulletLaurie : MonoBehaviour
{
    public float speedl = 20f;
    public Rigidbody2D rbl;
    void Start()
    {
        rbl.velocity = transform.right * -speedl;
    }
    void Update()
    //Pour faire dispara?tre le bullet ? partir de distance "pos" 
    {
        Vector2 pos = transform.position;
        pos.x -= speedl * Time.deltaTime;
        if (pos.x < -11)
        {
            Destroy(gameObject);
        }
        transform.position = pos;
    }
}

using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
    }
}
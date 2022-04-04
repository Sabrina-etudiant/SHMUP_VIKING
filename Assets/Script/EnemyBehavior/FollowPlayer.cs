using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        var gameObj = GameObject.FindGameObjectWithTag("Player");
        transform.position = Vector2.MoveTowards(transform.position, gameObj.transform.position, speed * Time.deltaTime);
    }
}
using UnityEngine;

public class MoveTowardMTP : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] float MoveTime;
    private bool IsMoving;

    private void Start()
    {
        IsMoving = true; 
        Invoke("Stop", MoveTime);
    }
    void Update()
    {
        if (IsMoving)
        {
            var gameObject = GameObject.FindGameObjectWithTag("MTP");
            transform.position = Vector2.MoveTowards(transform.position, gameObject.transform.position, speed * Time.deltaTime);

        }
        return;
    }
    void Stop()
    {
        IsMoving = false;
    }
}

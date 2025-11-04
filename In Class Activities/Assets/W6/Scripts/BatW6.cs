using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private Transform cat;

    private bool chasing = false;

    private void Update()
    {
        if (chasing)
        {
            float move_distance = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, cat.position, move_distance);
        }
    }

    public void stop_bat()
    {
        chasing = false;
    }

    public void start_bat()
    {
        chasing = true;
    }
}

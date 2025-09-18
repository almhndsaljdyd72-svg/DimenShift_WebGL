
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Transform[] patrolPoints;
    private int currentPoint = 0;

    void Update()
    {
        if (patrolPoints.Length == 0) return;
        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPoint].position, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, patrolPoints[currentPoint].position) < 0.1f)
            currentPoint = (currentPoint + 1) % patrolPoints.Length;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            Debug.Log("Player hit by enemy!");
    }
}

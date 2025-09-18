
using UnityEngine;

public class Resource : MonoBehaviour
{
    public int value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.CollectResource(value);
            Destroy(gameObject);
        }
    }
}


using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int totalResources = 0;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void CollectResource(int value)
    {
        totalResources += value;
        Debug.Log("Resource collected! Total: " + totalResources);
    }
}

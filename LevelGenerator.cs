
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] platforms;
    public GameObject[] resources;
    public Transform levelParent;

    public int platformCount = 20;

    void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel()
    {
        float x = 0f;
        float y = 0f;

        for (int i = 0; i < platformCount; i++)
        {
            GameObject platform = Instantiate(platforms[Random.Range(0, platforms.Length)], new Vector2(x, y), Quaternion.identity, levelParent);
            if (Random.value > 0.5f)
            {
                Instantiate(resources[Random.Range(0, resources.Length)], platform.transform.position + Vector3.up * 1f, Quaternion.identity, levelParent);
            }
            x += Random.Range(2f, 4f);
            y += Random.Range(-1f, 2f);
        }
    }
}

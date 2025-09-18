
using UnityEngine;

public class DimensionManager : MonoBehaviour
{
    public GameObject[] dimensions;
    private int currentDimension = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) SwitchDimension(-1);
        if (Input.GetKeyDown(KeyCode.E)) SwitchDimension(1);
    }

    void SwitchDimension(int dir)
    {
        dimensions[currentDimension].SetActive(false);
        currentDimension += dir;
        if (currentDimension < 0) currentDimension = dimensions.Length - 1;
        if (currentDimension >= dimensions.Length) currentDimension = 0;
        dimensions[currentDimension].SetActive(true);
    }
}


using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text resourceText;
    
    void Update()
    {
        resourceText.text = "Resources: " + GameManager.Instance.totalResources;
    }
}

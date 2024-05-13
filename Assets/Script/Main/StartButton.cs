using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject startBackground; // 비활성화할 StartBackground 오브젝트

    public void DisableStartBackground()
    {
        startBackground.SetActive(false); // StartBackground 오브젝트를 비활성화
    }
}

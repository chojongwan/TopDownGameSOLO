using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject startBackground; // ��Ȱ��ȭ�� StartBackground ������Ʈ

    public void DisableStartBackground()
    {
        startBackground.SetActive(false); // StartBackground ������Ʈ�� ��Ȱ��ȭ
    }
}

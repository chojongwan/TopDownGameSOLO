using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TMP_Text timeText;

    void Start()
    {
        InvokeRepeating("UpdateTime", 0f, 1f); // 1�ʸ��� UpdateTime �޼��� ȣ��
    }

    void UpdateTime()
    {
        timeText.text = DateTime.Now.ToString("HH:mm:ss"); // �ð� ���� �����Ͽ� �ؽ�Ʈ ������Ʈ
    }
}

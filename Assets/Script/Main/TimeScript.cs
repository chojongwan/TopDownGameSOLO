using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TMP_Text timeText;

    void Start()
    {
        InvokeRepeating("UpdateTime", 0f, 1f); // 1초마다 UpdateTime 메서드 호출
    }

    void UpdateTime()
    {
        timeText.text = DateTime.Now.ToString("HH:mm:ss"); // 시간 형식 지정하여 텍스트 업데이트
    }
}

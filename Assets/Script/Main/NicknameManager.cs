using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NicknameManager : MonoBehaviour
{
    public TMP_InputField nicknameInputField; // 닉네임 입력 받을 InputField

    public Text nicknameText; // 닉네임을 표시할 Text
    public Text nicknameText2; // 닉네임을 표시할 Text

    public void SetNickname()
    {
        // InputField에서 입력된 닉네임 가져오기
        string nickname = nicknameInputField.text;

        // 닉네임 Text에 표시하기
        nicknameText.text = nickname;
        nicknameText2.text = nickname;

    }
}

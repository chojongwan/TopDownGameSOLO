using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NicknameManager : MonoBehaviour
{
    public TMP_InputField nicknameInputField; // �г��� �Է� ���� InputField

    public Text nicknameText; // �г����� ǥ���� Text
    public Text nicknameText2; // �г����� ǥ���� Text

    public void SetNickname()
    {
        // InputField���� �Էµ� �г��� ��������
        string nickname = nicknameInputField.text;

        // �г��� Text�� ǥ���ϱ�
        nicknameText.text = nickname;
        nicknameText2.text = nickname;

    }
}

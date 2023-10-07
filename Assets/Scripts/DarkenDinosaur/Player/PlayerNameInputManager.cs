using UnityEngine;
using TMPro;

public class PlayerNameInputManager : MonoBehaviour
{
    public GameObject userNameObject;

    private void Awake()
    {
        // �������� ��������� TMP_InputField �� ������� UserName.
        TMP_InputField playerNameInputField = userNameObject.GetComponent<TMP_InputField>();

        // ���������, ��� ��������� TMP_InputField ��� ������.
        if (playerNameInputField != null)
        {
            // �������� ��������� �� ��������� �������� � ���� �����.
            playerNameInputField.onValueChanged.AddListener(OnPlayerNameChanged);
        }
    }

    private void OnPlayerNameChanged(string newName)
    {
        // ����� �� ������ ������������ ��������� � ����� ������.
        // newName - ��� ����� ��������� ��� ������.
    }
}
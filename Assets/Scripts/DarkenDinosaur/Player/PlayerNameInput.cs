using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerNameInput : MonoBehaviour
{
    public TMP_InputField playerNameInputField;

    private void Start()
    {
        // ���������� �������� ����������� ��� ������ �� PlayerPrefs.
        string savedPlayerName = PlayerPrefs.GetString("PlayerName", "");
        playerNameInputField.text = savedPlayerName;
    }

    private void Update()
    {
        // ���������� ����������� ��� ������ ��� ������ ��������� � ���� �����.
        string playerName = playerNameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();
    }
}
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerNameInput : MonoBehaviour
{
    public TMP_InputField playerNameInputField;

    private void Start()
    {
        // Попробуйте получить сохраненное имя игрока из PlayerPrefs.
        string savedPlayerName = PlayerPrefs.GetString("PlayerName", "");
        playerNameInputField.text = savedPlayerName;
    }

    private void Update()
    {
        // Обновляйте сохраненное имя игрока при каждом изменении в поле ввода.
        string playerName = playerNameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();
    }
}
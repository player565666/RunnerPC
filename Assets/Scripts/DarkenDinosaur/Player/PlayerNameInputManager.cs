using UnityEngine;
using TMPro;

public class PlayerNameInputManager : MonoBehaviour
{
    public GameObject userNameObject;

    private void Awake()
    {
        // Получите компонент TMP_InputField из объекта UserName.
        TMP_InputField playerNameInputField = userNameObject.GetComponent<TMP_InputField>();

        // Проверьте, что компонент TMP_InputField был найден.
        if (playerNameInputField != null)
        {
            // Добавьте слушателя на изменение значения в поле ввода.
            playerNameInputField.onValueChanged.AddListener(OnPlayerNameChanged);
        }
    }

    private void OnPlayerNameChanged(string newName)
    {
        // Здесь вы можете обрабатывать изменения в имени игрока.
        // newName - это новое введенное имя игрока.
    }
}
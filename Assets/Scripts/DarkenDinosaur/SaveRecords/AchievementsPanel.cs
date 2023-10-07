using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AchievementsPanel : MonoBehaviour
{
    private OutputListOfPlayers outputListOfPlayers;

    private void Start()
    {
        outputListOfPlayers = FindObjectOfType<OutputListOfPlayers>();
        if (outputListOfPlayers != null)
        {
            outputListOfPlayers.UpdateLeaderboard();
        }
        else
        {
            Debug.LogError("OutputListOfPlayers component not found.");
        }
    }
}
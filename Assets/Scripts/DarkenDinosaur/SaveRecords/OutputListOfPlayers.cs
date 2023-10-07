using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class OutputListOfPlayers : MonoBehaviour
{
    public TextMeshProUGUI leaderboardText;

    public void UpdateLeaderboard()
    {
        LeaderboardManager leaderboardManager = FindObjectOfType<LeaderboardManager>();

        if (leaderboardManager != null)
        {
            string[] playerNames = leaderboardManager.GetPlayerNames();
            int[] playerScores = leaderboardManager.GetPlayerScores();

            string leaderboardString = "";

            for (int i = 0; i < playerNames.Length; i++)
            {
                leaderboardString += "Player Name: " + playerNames[i] + "\nScore: " + playerScores[i] + "\n";
            }

            leaderboardText.text = leaderboardString;
        }
        else
        {
            leaderboardText.text = "Leaderboard is empty.";
        }
    }
    
}
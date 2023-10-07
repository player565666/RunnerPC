using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour
{
    private List<string> playerNames = new List<string>();
    private List<int> playerScores = new List<int>();

    public void SavePlayerScore(string playerName, int score)
    {
        playerNames.Add(playerName);
        playerScores.Add(score);
    }

    public string[] GetPlayerNames()
    {
        return playerNames.ToArray();
    }

    public int[] GetPlayerScores()
    {
        return playerScores.ToArray();
    }
}
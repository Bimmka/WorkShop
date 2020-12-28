#pragma warning disable 0649
using System;
using System.Collections.Generic;
using UnityEngine;

public class LapsController : MonoBehaviour
{
    [Header("Количество кругов для победы")]
    [SerializeField] private int countOfLapsToWin;

    private Dictionary<GameObject, int> dictionaryOfPlayersLaps = new Dictionary<GameObject, int>();

    public static Action<string> PlayerWin;

    private void Awake()
    {
        Player.SavePlayerLaps += TryToSaveLapsCount;
    }

    private void OnDisable()
    {
        Player.SavePlayerLaps -= TryToSaveLapsCount;
    }

    private void TryToSaveLapsCount (GameObject playerObject, int completedLaps)
    {
        if (!dictionaryOfPlayersLaps.ContainsKey(playerObject)) SavePlayerLapsCount(completedLaps, playerObject);
        else UpdatePlayerLapsCount(completedLaps, playerObject);
    }

    private void SavePlayerLapsCount(int completedLaps, GameObject playerObject)
    {
        dictionaryOfPlayersLaps.Add(playerObject, completedLaps);
    }

    private void UpdatePlayerLapsCount(int completedLaps, GameObject playerObject)
    {
        dictionaryOfPlayersLaps[playerObject] = completedLaps;
        CheckForLaggingPlayers();
    }

    private void CheckForLaggingPlayers()
    {
        GameObject playerWithMaxLaps = null;
        int maxCompletedLaps = SearchMaxCompletedLaps(ref playerWithMaxLaps);
        if (maxCompletedLaps == countOfLapsToWin)
        {
            PlayerWin?.Invoke(playerWithMaxLaps.name);
            return;
        }
    }

    private int SearchMaxCompletedLaps(ref GameObject player)
    {
        int maxLaps = 0;
        foreach (GameObject key in dictionaryOfPlayersLaps.Keys)
        {
            if (dictionaryOfPlayersLaps[key] > maxLaps)
            {
                maxLaps = dictionaryOfPlayersLaps[key];
                player = key;
            }
        }
        return maxLaps;
    }
}

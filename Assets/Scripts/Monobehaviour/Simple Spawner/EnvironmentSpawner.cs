#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawner : MonoBehaviour
{
    [Header("Опции спавна")]
    [SerializeField] private FirstSpawn_SO spawnOptions;
    private void Awake()
    {
        if (spawnOptions.IsSoloGame) SpawnSinglePlayerStarts();
        else SpawnMultiplayerStarts();
        if (spawnOptions.IsBonusSpawn) SpawnBonus();
        if (spawnOptions.IsStaffWorks) SpawnStaff();
        SpawnWalls();
    }

    private void SpawnSinglePlayerStarts()
    {
        GameObject start = Instantiate(Resources.Load<GameObject>("Downloaded Objects/First Spawn/Starts Single Player"), transform);
        SetCenterMap(start);
    }

    private void SpawnMultiplayerStarts()
    {
        GameObject start = Instantiate(Resources.Load<GameObject>("Downloaded Objects/First Spawn/Starts Myltiplayer"), transform);
        SetCenterMap(start);
    }

    private void SetCenterMap(GameObject starts)
    {
        IStart[] startInterfaces = starts.GetComponentsInChildren<IStart>();
        foreach (var start in startInterfaces)
        {
            start.SetMapCenter(transform);
        }
    }

    private void SpawnBonus()
    {
        Instantiate(Resources.Load<GameObject>("Downloaded Objects/First Spawn/Bonus"), transform);
    }

    private void SpawnStaff()
    {
        Instantiate(Resources.Load<GameObject>("Downloaded Objects/First Spawn/Cleaners"), transform);
    }

    private void SpawnWalls()
    {
        Instantiate(Resources.Load<GameObject>("Downloaded Objects/First Spawn/Walls"), transform);
    }

}

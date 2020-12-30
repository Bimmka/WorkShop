#pragma warning disable 0649
using Photon.Pun;
using UnityEngine;

public class MyltiplayerEnvironmentSpawner : MonoBehaviour
{
    [Header("Опции спавна")]
    [SerializeField] private FirstSpawn_SO spawnOptions;

    [Header("Старт")]
    [SerializeField] private GameObject startPrefab;

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
        GameObject start = PhotonNetwork.Instantiate(Resources.Load<GameObject>("Downloaded Objects/First Spawn/Starts Single Player").name, transform.position, transform.rotation);
        SetCenterMap(start);
    }

    private void SpawnMultiplayerStarts()
    {
        GameObject start = PhotonNetwork.Instantiate(startPrefab.name, transform.position + new Vector3(Random.Range(-5,5),Random.Range(-5,5)), transform.rotation);
        Debug.LogWarning(startPrefab.name);
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
        GameObject bonusPrefab = Resources.Load<GameObject>("Downloaded Objects/First Spawn/BonusM");
        PhotonNetwork.Instantiate(bonusPrefab.name, transform.position, transform.rotation);
    }

    private void SpawnStaff()
    {
        PhotonNetwork.Instantiate(Resources.Load<GameObject>("Downloaded Objects/First Spawn/Cleaners").name, transform.position, transform.rotation);
    }

    private void SpawnWalls()
    {
        PhotonNetwork.Instantiate(Resources.Load<GameObject>("Downloaded Objects/First Spawn/Walls").name, transform.position, transform.rotation);
    }

}

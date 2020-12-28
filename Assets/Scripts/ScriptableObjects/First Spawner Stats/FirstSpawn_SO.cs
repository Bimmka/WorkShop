#pragma warning disable 0649
using UnityEngine;

[CreateAssetMenu(fileName = "Spawn Options", menuName ="Create Spawn Optios/Spawn Options", order = 51)]
public class FirstSpawn_SO : ScriptableObject
{
    [Header("Игра для соло игры?")]
    [SerializeField] private bool isSoloGame = true;

    [Header("Спавнить работников маркета?")]
    [SerializeField] private bool isStaffWorks = true;

    [Header("Спавнить бонусы?")]
    [SerializeField] private bool isBonusSpawn = true;

    public bool IsSoloGame => isSoloGame;
    public bool IsStaffWorks => isStaffWorks;
    public bool IsBonusSpawn => isBonusSpawn;
}

#pragma warning disable 0649
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayersLaps : MonoBehaviour
{
    [Header("Текст для второго игрока")]
    [SerializeField] private Image player2Image;

    [Header("Текст для первого игрока")]
    [SerializeField] private Image  player1Image;

    [Header("Табло первого игрока")]
    [SerializeField] private Sprite[] secondPlayerTabloSprites;

    [Header("Табло первого игрока")]
    [SerializeField] private Sprite[]  firstPlayerTabloSprites;

    private void Awake()
    {
        Player.DisplayCompletedLaps += SetPlayerLaps;
    }

    private void OnDisable()
    {
        Player.DisplayCompletedLaps -= SetPlayerLaps;
    }

    private void SetPlayerLaps(int numberOfLaps, string playerName)
    {
        playerName = playerName.Remove(playerName.IndexOf("(Clone)"));
        switch (playerName)
        {
            case "Player1":
                player1Image.sprite = firstPlayerTabloSprites[numberOfLaps];
                break;
            case "Player2":
                player2Image.sprite = secondPlayerTabloSprites[numberOfLaps];
                break;
        }
    }
}

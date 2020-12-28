#pragma warning disable 0649
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayersEnergy : MonoBehaviour
{
    [Header("Картинка для первого игрока")]
    [SerializeField] private Image player1Image;

    [Header("Картинка для второго игрока")]
    [SerializeField] private Image player2Image;

    [Header("Картинка для изменении энергии первого игрока")]
    [SerializeField] private Image player1EnergyChangePanel;

    [Header("Картинка для изменении энергии второго игрока")]
    [SerializeField] private Image player2EnergyChangePanel;

    [Header("Текст для первого игрока")]
    [SerializeField] private TMP_Text  player1Text;

    [Header("Текст для второго игрока")]
    [SerializeField] private TMP_Text player2Text;

    private float intervalForResetEnergyPanelAlpha = 0.3f;
    private void Awake()
    {
        Player.DisplayEnergy += SetPlayerEnergy;
        Player.DisplayResetEnergy += SetPlayerResetEnergy;
        Player.EnergyChanged += PlayerEnergyChange;

    }

    private void OnDisable()
    {
        Player.DisplayEnergy -= SetPlayerEnergy;
        Player.DisplayResetEnergy -= SetPlayerResetEnergy;
        Player.EnergyChanged -= PlayerEnergyChange;
    }

    private void SetPlayerEnergy(float currentPlyerEnergy, float maxPlayerEnergy, string playerName)
    {
        playerName = playerName.Remove(playerName.IndexOf("(Clone)"));
        switch (playerName)
        {
            case "Player1":
                player1Image.fillAmount = currentPlyerEnergy / maxPlayerEnergy;
                break;
            case "Player2":
                player2Image.fillAmount = currentPlyerEnergy / maxPlayerEnergy;
                break;
        }
    }

    private void SetPlayerResetEnergy(string timeLeft, string playerName)
    {
        playerName = playerName.Remove(playerName.IndexOf("(Clone)"));
        switch (playerName)
        {
            case "Player1":
                player1Text.text = timeLeft;
                break;
            case "Player2":
                player2Text.text = timeLeft;
                break;
        }
    }

    private void PlayerEnergyChange(string playerName)
    {
        playerName = playerName.Remove(playerName.IndexOf("(Clone)"));
        switch (playerName)
        {
            case "Player1":
                DisplayChangeEnergy(player1EnergyChangePanel);
                break;
            case "Player2":
                DisplayChangeEnergy(player2EnergyChangePanel);
                break;
        }
    }

    private void DisplayChangeEnergy(Image energyChangePanel)
    {
        Color tempPanelColor = energyChangePanel.color;
        ChangeImageColor(energyChangePanel, tempPanelColor, 255);
        StartCoroutine(ResetChangeEnergyPanelValue(energyChangePanel, tempPanelColor, 0));

    }

    private void ChangeImageColor(Image changePanel, Color tempColor, float alphaValue)
    {
        tempColor.a = alphaValue;
        changePanel.color = tempColor;
    }

    private IEnumerator ResetChangeEnergyPanelValue(Image changePanel, Color tempColor, float alphaValue)
    {
        yield return new WaitForSeconds(intervalForResetEnergyPanelAlpha);
        ChangeImageColor(changePanel, tempColor, alphaValue);
    }
}

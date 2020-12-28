#pragma warning disable 0649
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCanvas : MonoBehaviour
{
    [Header("Куда выводить текст")]
    [SerializeField] private TMP_Text winText;

    [Header("CanvasGroup Canvas, в котором выводим")]
    [SerializeField] private CanvasGroup winCanvasGroup;

    [Header("AudioSource при победе игрока")]
    [SerializeField] private AudioSource playerWinSound;

    private void Awake()
    {
        LapsController.PlayerWin += PlayerWin;
        SetCanvasGroup(0, false, false);
    }

    private void OnDisable()
    {
        LapsController.PlayerWin -= PlayerWin;
    }

    private void PlayerWin(string playerName)
    {
        Time.timeScale = 0f;

        playerName = playerName.Remove(playerName.IndexOf("(Clone)"));
        winText.text = playerName + " wins!";

        SetCanvasGroup(1, true, true);

        playerWinSound.Play();
        
    }

    private void SetCanvasGroup(float alpha, bool raycast, bool interactable)
    {
        winCanvasGroup.alpha = alpha;
        winCanvasGroup.interactable = interactable;
        winCanvasGroup.blocksRaycasts = raycast;
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
}

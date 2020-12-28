#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class MainMenu : MonoBehaviour
{
    [Header("CanvasGroup основного меню")]
    [SerializeField] private CanvasGroup mainPanelCanvasGroup;

    [Header("CanvasGroup туториала")]
    [SerializeField] private CanvasGroup tutorialPanelCanvasGroup;

    [Header("CanvasGroup меню-заставки")]
    [SerializeField] private CanvasGroup screenPanelCanvasGroup;

    private float waitIntervalCoeff = 2;

    private void Awake()
    {
        SetCanvasGroup(screenPanelCanvasGroup, 1, true, true);
        SetCanvasGroup(mainPanelCanvasGroup, 0, false, false);
        SetCanvasGroup(tutorialPanelCanvasGroup, 0, false, false);

        StartCoroutine(SetScreenAlpha());
    }

    private void SetCanvasGroup(CanvasGroup canvasGorup, float alpha, bool raycast, bool interactable)
    {
        canvasGorup.alpha = alpha;
        canvasGorup.blocksRaycasts = raycast;
        canvasGorup.interactable = interactable;
    }

    public void GoToMenu()
    {
        SetCanvasGroup(mainPanelCanvasGroup, 1, true, true);
        SetCanvasGroup(tutorialPanelCanvasGroup, 0, false, false);
    }

    public void GoToTutorial()
    {
        SetCanvasGroup(mainPanelCanvasGroup, 0, false, false);
        SetCanvasGroup(tutorialPanelCanvasGroup, 1, true, true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene("Game Scene 1");
    }

    private IEnumerator SetScreenAlpha()
    {
        while (screenPanelCanvasGroup.alpha > 0)
        {
            screenPanelCanvasGroup.alpha -= Time.deltaTime / waitIntervalCoeff;
            yield return null;
        }
        SetCanvasGroup(screenPanelCanvasGroup, 0, false, false);
        SetCanvasGroup(mainPanelCanvasGroup, 1, true, true);
    }
}

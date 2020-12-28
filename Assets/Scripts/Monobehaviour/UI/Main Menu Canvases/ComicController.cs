#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ComicController : MonoBehaviour
{
    [Header("Картинки для комикса")]
    [SerializeField] private Sprite[] comicSprites;

    [Header("Куда отображать картинки")]
    [SerializeField] private Image  viewSpriteRenderer;

    private int currentComicIndex = 0;
    private int maxComicPage;

    private void Awake()
    {
        maxComicPage = comicSprites.Length;
        DisplayComicPage();
    }

    private void DisplayComicPage()
    {
        viewSpriteRenderer.sprite = comicSprites[currentComicIndex];
    }

    private void LoadGameLevel()
    {
        SceneManager.LoadScene("Game Scene 1");
    }

    public void GoToNextPage()
    {
        currentComicIndex++;
        if (currentComicIndex < maxComicPage) DisplayComicPage();
        else LoadGameLevel();
    }

    public void GoToPreviousPage()
    {
        currentComicIndex--;
        currentComicIndex = Mathf.Clamp(currentComicIndex, 0, maxComicPage);
        DisplayComicPage();
    }


}

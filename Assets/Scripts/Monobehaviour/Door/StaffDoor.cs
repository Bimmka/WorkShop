#pragma warning disable 0649
using System.Collections;
using UnityEngine;

public class StaffDoor : MonoBehaviour
{
    [Header("Спрайт открытой двери")]
    [SerializeField] private Sprite openDoor;

    [Header("Спрайт закрытой двери")]
    [SerializeField] private Sprite closeDoor;

    [Header("Sprite Rendered")]
    [SerializeField] private SpriteRenderer doorSpriteRenderer;

    [Header("Уборщик, который через нее проходит")]
    [SerializeField] private GameObject cleaner;

    private IWorker cleanerInterface;

    private float checkInterval = 0.2f;

    private void Awake()
    {
        doorSpriteRenderer.sprite = closeDoor;
        cleaner.TryGetComponent(out cleanerInterface);
        StartCoroutine(CheckForCleaner());
    }

    private IEnumerator CheckForCleaner()
    {
        while (true)
        {
            yield return new WaitForSeconds(checkInterval);
            if (cleanerInterface.IsMoved()) OpenDoor();
            else CloseDoor();
        }
    }

    private void OpenDoor()
    {
        doorSpriteRenderer.sprite = openDoor;
    }

    private void CloseDoor()
    {
        doorSpriteRenderer.sprite = closeDoor;
    }
}

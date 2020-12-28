#pragma warning disable 0649
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class GroceryShelf : MonoBehaviour
{
    [Header("Объект для падения")]
    [SerializeField] private GameObject fallenObject;

    [Header("Смещение для спавна")]
    [SerializeField] private Vector3 offset;

    [Header("AudioSource sound of fallen object")]
    [SerializeField] private AudioSource fallenObjectSound;

    private IFallenObject fallenObjectInterface;

    private bool isFallen = false;
    private void Awake()
    {
        fallenObject.TryGetComponent(out fallenObjectInterface);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            if (!isFallen) PrepareToFallObject(collision.transform.position);
        }
    }

    private void PrepareToFallObject(Vector3 hitPosition)
    {
        isFallen = true;
        FallObject();
    }
    private void FallObject()
    {
        float duration = fallenObjectInterface.FallObject();
        fallenObjectSound.Play();
        StartCoroutine(ResetIsFallen(duration));
    }

    private IEnumerator ResetIsFallen(float duration)
    {
        yield return new WaitForSeconds(duration);
        isFallen = false;
    }
}

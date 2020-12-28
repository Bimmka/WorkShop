#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Mine : MonoBehaviour
{
    [Header("Время стана игрока")]
    [SerializeField] private float stunDuration;

    [Header("Время подготовки мины")]
    [SerializeField] private float minePrepareInterval;

    private BoxCollider2D mineCollider;

    private void Awake()
    {
        TryGetComponent(out mineCollider);
        mineCollider.enabled = false;

        StartCoroutine(CountdownToMinePrepare());
    }

    private IEnumerator CountdownToMinePrepare()
    {
        yield return new WaitForSeconds(minePrepareInterval);
        mineCollider.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player>() != null)
        {
            other.GetComponent<IPlayerMovement>().HitMine(stunDuration);
            other.GetComponent<IPlayerAnimation>().HitBomb();
            Destroy(gameObject);
        }
    }
}

#pragma warning disable 0649
using UnityEngine;

public class CleanerTriggers : MonoBehaviour
{
    [Header("Какой работник будет передвигаться от этого тригера")]
    [SerializeField] private GameObject staffWorker;

    private IWorker staffInterface;

    private void Awake()
    {
        staffWorker.TryGetComponent(out staffInterface);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player>() != null) StartWorkerMove();
    } 

    private void StartWorkerMove()
    {
        staffInterface.SetToFinishPoint();
    }
}

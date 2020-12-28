#pragma warning disable 0649
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Cleaner : MonoBehaviour, IWorker
{
    [Header("Конечная точка работника")]
    [SerializeField] private Transform finishPoint;

    [Header("Скорость движения")]
    [SerializeField] private float moveSpeed;

    [Header("Через сколько идти назад")]
    [SerializeField] private float waitInterval;

    [Header("Сколько можно не дойти до точки назначения")]
    [SerializeField] private float distanceOffset;

    private bool isMoved = false;

    private Vector3 startPoint;

    private void Awake()
    {
        startPoint = transform.position;
    }   

    private IEnumerator GoToPoint(Vector3 finishPosition, bool isFinishPoint)
    {
        while (Vector3.Distance( transform.position,finishPosition) > distanceOffset)
        {
            transform.position += (finishPosition - transform.position ) * moveSpeed * Time.deltaTime;
            yield return null;
        }
        if (isFinishPoint) StartCoroutine(WaitToReturn());
    }

    private IEnumerator WaitToReturn()
    {
        yield return new WaitForSeconds(waitInterval);
        StartCoroutine(WaitForStartPosition());
    }

    private IEnumerator WaitForStartPosition()
    {
        StartCoroutine(GoToPoint(startPoint, false));
        while (Vector3.Distance(transform.position, startPoint) > distanceOffset)
        {
            yield return null;
        }

        isMoved = false;
    }

    public void SetToFinishPoint()
    {
        if (!isMoved)
        {
            isMoved = true;
            StartCoroutine(GoToPoint(finishPoint.position, true));
        }
    }

    public bool IsMoved()
    {
        return isMoved;
    }
}

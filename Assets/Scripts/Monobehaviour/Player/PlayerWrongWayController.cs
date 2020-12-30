using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWrongWayController : MonoBehaviour, IWrongWay
{
    private Vector3 mapCenterPosition;
    private Vector3 safePosistion;

    private bool isWrongWay = false;
    private bool isStayOnRightWay = false;

    private float checkInterval = 0.1f;
    private float returnToRightWayInterval = 1f;

    private Rigidbody2D playerRigidbody;

    private void Start()
    {
        TryGetComponent(out playerRigidbody);
        StartCoroutine(CheckForWrongWay());
    }

    private IEnumerator CheckForWrongWay()
    {
        while (true)
        {
            yield return new WaitForSeconds(checkInterval);
            isWrongWay = IsPlayerOnWrongWay(transform.right, mapCenterPosition - transform.position);
            if (isWrongWay)
            {
                if (!isStayOnRightWay) SetPlayerOnRightWay();
            }
            else if (isStayOnRightWay) ResetSetPlayerOnRightWay();
                
        }
    }

    /// <summary>
    /// Проверяет, что угол между векторами в диапазоне от 0 до 180
    /// </summary>
    /// <param name="firstVector"></param>
    /// <param name="secondVector"></param>
    /// <returns></returns>
    private bool IsPlayerOnWrongWay(Vector2 firstVector, Vector2  secondVector)
    {
        float angle = Vector2.SignedAngle(firstVector,  secondVector);
        if (angle >= 0 && angle <= 180) return false;
        return true;
    }

    /// <summary>
    /// Ставим персонажа на правильный путь
    /// </summary>
    private void SetPlayerOnRightWay()
    {
        safePosistion = transform.position;
        isStayOnRightWay = true;
        StartCoroutine(CountdownToReturnOnWay());
    }

    /// <summary>
    /// Поворачиваем персонажа, чтобы смотрел в правильную сторону
    /// </summary>
    /// <returns></returns>
    private IEnumerator CountdownToReturnOnWay()
    {
        yield return new WaitForSeconds(returnToRightWayInterval);

      //  float angleToRotate = TryToSpawnPlayerWithRotation();
        isStayOnRightWay = false;

        transform.DORotate(transform.eulerAngles + Quaternion.AngleAxis(Vector2.SignedAngle(transform.up, mapCenterPosition - transform.position), Vector3.forward).eulerAngles, 0f);
        transform.position = safePosistion;

        playerRigidbody.velocity = new Vector2(0, 0);
        playerRigidbody.angularVelocity = 0f;
    }

    /// <summary>
    /// Если игрок смог сам повернуть
    /// </summary>
    private void ResetSetPlayerOnRightWay()
    {
        StopAllCoroutines();
        isStayOnRightWay = false;
        StartCoroutine(CheckForWrongWay());
    }

    /// <summary>
    /// Устанавливаем позицию центра карты
    /// </summary>
    /// <param name="position">Координата цента карты</param>
    public void SetMapCenter(Vector3 position)
    {
        mapCenterPosition = position;
    }

    public bool IsWrongWay()
    {
        return isWrongWay;
    }
}

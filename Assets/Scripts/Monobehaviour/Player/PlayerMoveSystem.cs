#pragma warning disable 0649
using UnityEngine;
using DG.Tweening;
using System;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMoveSystem : MonoBehaviour, IPlayerMovement
{
    [Header("Скорость движения персонажа")]
    [SerializeField] private float moveSpeed;

    [Header("Скорость поворота персонажа")]
    [SerializeField] private float rotateSpeed;

    [Header("Система ввода для поворотов")]
    [SerializeField] private string horizontalInputSystemName;

    [Header("Система ввода для движения вперед")]
    [SerializeField] private string verticalInputSystemName;

    [Header("Звук задевания мины")]
    [SerializeField] private AudioSource hitMineSound;

    private Rigidbody2D playerRigidbody;
    private IPlayer playerInterface;
    private IPlayerAnimation playerAnimationInterface;

    private float currentMoveSpeed = 0f;
    private float currentRotateSpeed = 0f;

    public bool isCanMove = true;

    public string VerticalInput => verticalInputSystemName;

    public static Action<bool> WrongWay;

    private void Awake()
    {
        TryGetComponent(out playerRigidbody);
        currentMoveSpeed = moveSpeed;
        currentRotateSpeed = rotateSpeed;
        playerInterface = GetComponent<IPlayer>();
        playerAnimationInterface = GetComponent<IPlayerAnimation>();
    }

    private void Update()
    {
        InputAxis();
    }

    /// <summary>
    /// Отлавливаем нажатие клавиши
    /// </summary>
    private void InputAxis()
    {
        float verticalInput = Input.GetAxis(verticalInputSystemName);
        if (verticalInput < 0) MovePlayer();

        float horizontal = Input.GetAxis(horizontalInputSystemName);
        if (horizontal != 0) RotatePlayer(Mathf.Sign(horizontal));
    }

    /// <summary>
    /// Двигаем персонажа вперед
    /// </summary>
    private void MovePlayer()
    {
        playerRigidbody.AddForce(transform.right * currentMoveSpeed * Time.deltaTime);
    }

    /// <summary>
    /// Поворачиваем персонажа со скорость rotateSpeed в направлении direction
    /// </summary>
    /// <param name="direction"></param>
    private void RotatePlayer(float direction)
    {
        transform.DORotate(transform.eulerAngles + Quaternion.AngleAxis(currentRotateSpeed * Time.deltaTime * direction, Vector3.forward).eulerAngles, 0f);
    }

    public void HitMine(float duration)
    {
        if (isCanMove)
        {
            hitMineSound.Play();
            StartCoroutine(CountdownInabilityToMove(duration));
        }
    }

    private IEnumerator CountdownInabilityToMove(float effectDuration)
    {
        isCanMove = false;
        SetCharacteristicks(0, 0, isCanMove);

        yield return new WaitForSeconds(effectDuration);

        isCanMove = true;
        SetCharacteristicks(moveSpeed, rotateSpeed, isCanMove);
    }

    private void SetCharacteristicks(float speed, float rotateSpeed, bool isCanMoveValue)
    {
        currentMoveSpeed = speed;
        currentRotateSpeed = rotateSpeed;
        playerInterface.IsCanMove(isCanMoveValue);
        playerAnimationInterface.ChangeAnimatorSpeed(isCanMoveValue?1:0.2f);
    }

    public void StopTiredPlayerMove(float duration)
    {
        if (isCanMove) StartCoroutine(CountdownInabilityToMove(duration));
    }
}

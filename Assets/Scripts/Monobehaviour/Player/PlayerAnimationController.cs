#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAnimationController : MonoBehaviour, IPlayerAnimation
{
    [Header("Значения углов для вида спереди. Формат (мин.знач, длина диапазона")]
    [SerializeField] private float[] angleForForwardView;

    [Header("Значения углов для вида справа. Формат (мин.знач, длина диапазона")]
    [SerializeField] private float[] angleForRightView;

    [Header("Значения углов для вида слева. Формат (мин.знач, длина диапазона")]
    [SerializeField] private float[] angleForLeftView;

    [Header("Значения углов для вида сзади. Формат (мин.знач, длина диапазона")]
    [SerializeField] private float[] angleForBehindView;

    [Header("Animator, через который выставляются анимации персонажа")]
    [SerializeField] private Animator playerAnimator;

    private Dictionary<float[], string> playerViewByAngleDictionary = new Dictionary<float[], string>();

    private IVfxRotate vfxRotate;

    private void Awake()
    {
        playerViewByAngleDictionary.Add(angleForBehindView, "Behind");
        playerViewByAngleDictionary.Add(angleForLeftView, "Left");
        playerViewByAngleDictionary.Add(angleForRightView, "Right");
        playerViewByAngleDictionary.Add(angleForForwardView, "Forward");
        vfxRotate = GetComponentInChildren<IVfxRotate>();
    }

    private void Update()
    {
        SetAnimationByView(GetViewByAngle());
    }

    private string GetViewByAngle()
    {
        float zRotation = transform.rotation.eulerAngles.z;
        foreach (var key in playerViewByAngleDictionary.Keys)
        {
            if ((zRotation >= key[0] && zRotation <= (key[0] + key[1])) || (zRotation < key[0]+key[1] - 360))
            {
                vfxRotate.SetRotateByView(playerViewByAngleDictionary[key]);
                return playerViewByAngleDictionary[key];
            }
        }
        return string.Empty;
    }

    private void SetAnimationByView(string currentView)
    {
        foreach (var key in playerViewByAngleDictionary.Keys)
        {
            if (playerViewByAngleDictionary[key] == currentView) playerAnimator.SetBool(playerViewByAngleDictionary[key], true);
            else playerAnimator.SetBool(playerViewByAngleDictionary[key], false);
        }
    }

    public void SetIsHaveBomb(bool isHave)
    {
        playerAnimator.SetBool("IsFull", isHave);
    }

    public void HitBomb()
    {
        playerAnimator.SetTrigger("Hit");
    }

    public void ChangeAnimatorSpeed(float speedValue)
    {
        playerAnimator.speed = speedValue;
    }
}

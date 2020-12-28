#pragma warning disable 0649
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    [Header("Сила тряски")]
    [SerializeField] private float shakeStrength;

    [Header("Длительность  тряски")]
    [SerializeField] private float shakeDuration;

    [Header("AudioSource player crashed")]
    [SerializeField] private AudioSource playerCrashedSound;

    private Camera mainCamera;
    private bool isShaked = false;

    private void Awake()
    {
        mainCamera = Camera.main;
        Player.PlayersCrashed += TryShakeCamera;
    }

    private void OnDisable()
    {
        Player.PlayersCrashed -= TryShakeCamera;
    }

    private void TryShakeCamera()
    {
        if (!isShaked)
        {
            isShaked = true;
            ShakeCamera();
        }
    }

    private void ShakeCamera()
    {
        playerCrashedSound.Play();
        mainCamera.DOShakePosition(shakeDuration, shakeStrength);
        StartCoroutine(ResetIsShaked());
    }

    private IEnumerator ResetIsShaked()
    {
        yield return new WaitForSeconds(shakeDuration);
        isShaked = false;
    }
}

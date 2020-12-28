#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObject : MonoBehaviour, IFallenObject
{
    [Header("Animator, через который проигрываем анимации")]
    [SerializeField] private Animator objectAnimator;

    [Header("Animation Fall Clip")]
    [SerializeField] private AnimationClip fallClip;

    public float FallObject()
    {
        objectAnimator.SetTrigger("Fallen");
        return fallClip.length;
    }
}

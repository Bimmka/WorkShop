#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Security : MonoBehaviour
{
    [Header("Animator для охранника")]
    [SerializeField] private Animator securityAnimator;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null) GreetGrandma();
    }

    private void GreetGrandma()
    {
        securityAnimator.SetTrigger("Greet");
    }
}

#pragma warning disable 0649
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Bonus : MonoBehaviour
{
    [Header("На сколько увеличиваем/уменьшаем (-) энергию игрока, % от максимального значения")]
    [SerializeField] private float bonusCoeff;

    [Header("Audio Source player take bonus")]
    [SerializeField] private AudioSource playerTakeBonusSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            collision.GetComponent<IPlayer>().ChangePlayerEnergy(bonusCoeff);
            playerTakeBonusSound.Play();
        }
    }
}

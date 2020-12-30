#pragma warning disable 0649
using System;
using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(PlayerMoveSystem)), RequireComponent(typeof(PlayerWrongWayController)), RequireComponent(typeof(PlayerAnimationController))]
public class Player : MonoBehaviour, IPlayer
{
    [Header("Место спавна бомбы")]
    [SerializeField] private Transform bombSpawn;

    [Header("Максимальное количество энергии")]
    [SerializeField] private float maxEnergy;

    [Header("Максимальное количество энергии")]
    [SerializeField] private float wasteEnergy;

    [Header("Количество энергии на установку бомбы")]
    [SerializeField] private float bombSetEnergy;

    [Header("AudioSource set bomb")]
    [SerializeField] private AudioSource setBombSound;

    private GameObject bomb;

    private bool isCanMove = true;

    private int numberOfCompletedLaps = -1;

    private float currentEnergy = 0f;

    private float intervalOfWasteEnergy = 1f;
    private float intervalOfResetEnergy = 3f;

    private IPlayerMovement playerMovement;
    private IPlayerAnimation playerAnimation;

    protected PlayerInputs playerInputs;
    protected int currentNumberOfBomb = 0;

    public static Action<int,string> DisplayCompletedLaps;
    public static Action<GameObject, int> SavePlayerLaps;
    public static Action<float, float, string> DisplayEnergy;
    public static Action<string, string> DisplayResetEnergy;
    public static Action PlayersCrashed;
    public static Action<string> EnergyChanged;
    private void Awake()
    {
        bomb = Resources.Load<GameObject>("Downloaded Objects/Mine/Mine");
        currentEnergy = maxEnergy;
        TryGetComponent(out playerMovement);
        TryGetComponent(out playerAnimation);
        playerInputs = new PlayerInputs();
    }


    protected virtual void OnEnable()
    {
    }

    protected virtual void OnDisable()
    {
    }
    private void Start()
    {
        DisplayEnergy?.Invoke(currentEnergy, maxEnergy, name);
        StartCoroutine(WasteOfEnergy());
    }
    protected virtual void Update()
    {
        TrySetBomb();
    }

    protected virtual void TrySetBomb()
    {
       
    }

    protected void SetBomb()
    {
        currentNumberOfBomb--;
        setBombSound.Play();
        if (currentNumberOfBomb == 0) playerAnimation.SetIsHaveBomb(false);
        currentEnergy -= currentEnergy * bombSetEnergy;
        Instantiate(bomb, bombSpawn.position, Quaternion.identity);       
    }

    private IEnumerator WasteOfEnergy()
    {
        while (currentEnergy > 0)
        {
            if (isCanMove)
            {
                currentEnergy -= wasteEnergy;
                DisplayEnergy?.Invoke(currentEnergy, maxEnergy, name);
            }
            yield return new WaitForSeconds (intervalOfWasteEnergy);
        }
        StartCoroutine(ResetEnergy(intervalOfResetEnergy));
    }

    private IEnumerator ResetEnergy(float waitTime)
    {
        playerMovement.StopTiredPlayerMove(waitTime);
        while (waitTime >0)
        {
            DisplayResetEnergy?.Invoke(waitTime.ToString("0.00"), name);
            waitTime -= Time.deltaTime;
            yield return null;
        }
        DisplayResetEnergy?.Invoke("", name);
        currentEnergy = maxEnergy;
        DisplayEnergy?.Invoke(currentEnergy, maxEnergy, name);
        StartCoroutine(WasteOfEnergy());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)   PlayersCrashed?.Invoke();
    }

    private void ClampCurrentEnergy()
    {
        currentEnergy = Mathf.Clamp(currentEnergy, 0, maxEnergy);
    }

    public void IncPlayerCompletedLaps()
    {
        numberOfCompletedLaps++;
        currentNumberOfBomb++;

        if (currentNumberOfBomb > 0) playerAnimation.SetIsHaveBomb(true);
        if (numberOfCompletedLaps < 0) DisplayCompletedLaps?.Invoke(0, name);
        else DisplayCompletedLaps?.Invoke(numberOfCompletedLaps, name);
        SavePlayerLaps?.Invoke(gameObject, numberOfCompletedLaps);
    }

    public void IsCanMove(bool value)
    {
        isCanMove = value;
    }

    public void ChangePlayerEnergy(float changeEnergy)
    {
        currentEnergy += changeEnergy*currentEnergy;
        ClampCurrentEnergy();
        EnergyChanged?.Invoke(name);
    }
}

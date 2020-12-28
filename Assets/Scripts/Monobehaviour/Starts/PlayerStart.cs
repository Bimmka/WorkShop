#pragma warning disable 0649
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class PlayerStart : MonoBehaviour, IStart
{
    [Header("Какого персонажа спавним")]
    [SerializeField] private string playerName;

    [Header("Коэффициент увеличения массы")]
    [SerializeField] private float massCoeff;

    private Transform mapCenter;

    private bool isIncedPlayerStats = false;

    private void Start()
    {
        GameObject player = Instantiate(Resources.Load<GameObject>("Downloaded Objects/Players/" + playerName), transform.position, transform.rotation);
        player.GetComponent<IWrongWay>().SetMapCenter(mapCenter.position);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Remove(other.name.IndexOf("(Clone)")) == playerName && !isIncedPlayerStats)
        {
            if (!other.GetComponent<IWrongWay>().IsWrongWay())
            {
                isIncedPlayerStats = true;
                other.GetComponent<IPlayer>().IncPlayerCompletedLaps();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name.Remove(other.name.IndexOf("(Clone)")) == playerName && isIncedPlayerStats)
        {
                isIncedPlayerStats = false;
        }
    }
    public void SetMapCenter(Transform center)
    {
        mapCenter = center;
    }
}

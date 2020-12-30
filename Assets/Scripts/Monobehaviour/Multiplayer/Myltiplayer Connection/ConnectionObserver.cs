using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionObserver : MonoBehaviourPunCallbacks
{
    public override void OnLeftRoom()
    {
        Debug.LogWarning($"{PhotonNetwork.NickName} left room");

        PhotonNetwork.LoadLevel(0);
    }

    public override void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer)
    {
        Debug.LogWarning($"{otherPlayer.NickName} left room");
    }

    public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer)
    {
        Debug.LogWarning($"{newPlayer.NickName} entered room");
    }

    public void LeftRoom()
    {
        PhotonNetwork.LeaveRoom();
    }
}

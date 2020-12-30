using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyltiplayerConnection : MonoBehaviourPunCallbacks
{
    [Header("Лог-чат")]
    [SerializeField] private Text logChat;

    private void Awake()
    {
        PhotonNetwork.NickName = "Player" + Random.Range(0, 10);
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.AutomaticallySyncScene = true;

        PhotonNetwork.ConnectUsingSettings();

        Log($"Player with nickname {PhotonNetwork.NickName} created");
    }

    private void Log(string logText)
    {
        Debug.LogWarning(logText);

        logChat.text += logText + "\n";
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions { MaxPlayers = 2 });
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRandomRoom();        
    }

    public override void OnConnectedToMaster()
    {
        Log($"{PhotonNetwork.NickName} connected to Server");
    }

    public override void OnCreatedRoom()
    {
        Log($"{PhotonNetwork.NickName} created room");
    }

    public override void OnJoinedRoom()
    {
        Log($"{PhotonNetwork.NickName} joined room");

        PhotonNetwork.LoadLevel("Game Scene 2");
    }
}

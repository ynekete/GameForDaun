using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityStandardAssets.Characters.FirstPerson;

public class Connect : MonoBehaviourPunCallbacks
{
    public GameObject Player;
    public GameObject SpawnPoint;

    public void StartGame()
    {
        PhotonNetwork.GameVersion = "0.1";
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom("", new Photon.Realtime.RoomOptions {MaxPlayers = 20});
    }

    public override void OnJoinedRoom()
    {
        GameObject Human = PhotonNetwork.Instantiate(Player.name, SpawnPoint.transform.position, Quaternion.identity);
        Human.GetComponent<FirstPersonController>().enabled = true;
        
    }

    public void Start()
    {
        StartGame();
    }
}

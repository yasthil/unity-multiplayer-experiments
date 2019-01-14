using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonManager : MonoBehaviour
{

    public GameObject _statusGO;
    public string _gameVersion = "0.01";

    public void ConnectToPhoton()
    {
        // connect to Photon
        PhotonNetwork.GameVersion = _gameVersion;
        PhotonNetwork.ConnectUsingSettings();
        UpdateStatus("Connecting...");
    }

    private void OnConnectedToMaster()
    {
        UpdateStatus("Connected to server!");
    }

    private void UpdateStatus(string status)
    {
        _statusGO.GetComponent<Text>().text = status;
    }

}

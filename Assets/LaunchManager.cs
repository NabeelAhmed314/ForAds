using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LaunchManager : MonoBehaviourPunCallbacks
{
    public void ConnectedToPhotonServer()
    {
        if (!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log(PhotonNetwork.NickName + "  is Connected to server");
    }

    public override void OnConnected()
    {
        Debug.Log("Connected to Internet");
    }
}

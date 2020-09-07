using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;



public class PlayerNameInput : MonoBehaviour
{
    public void SetPlayerName(string playerName)
    {
        if (string.IsNullOrEmpty(playerName))
        {
            Debug.Log("Player Name is Empty");
            return;
        }
        PhotonNetwork.NickName = playerName;
    }

}

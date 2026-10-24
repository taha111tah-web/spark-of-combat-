using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class CyberNetworkManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        // الاتصال بسيرفرات اللعبة السحابية
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("تم الاتصال بنجاح بسيرفر اللعبة!");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }
}

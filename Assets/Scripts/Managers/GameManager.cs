using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class GameManager : MonoBehaviour
{
    #region Singleton

    static GameManager _instance = null;

    public static GameManager getInstance() 
    {
        return _instance;
    }

    #endregion

    #region Variables

    static GameObject localPlayer = null;

    #endregion

    void Start()
    {
        if (_instance == null) _instance = this;
        else Destroy(this);

        if (PhotonNetwork.IsMasterClient)
        {
            localPlayer = PhotonNetwork.Instantiate("PlayerPrefab", new Vector3(2f, 0, 0), Quaternion.identity);
        }
        else
        {
            localPlayer = PhotonNetwork.Instantiate("PlayerPrefab", new Vector3(-2f, 0, 0), Quaternion.identity);
        }

        localPlayer.transform.SetParent(transform.GetChild(0));

    }

    void Update()
    {
        
    }
}

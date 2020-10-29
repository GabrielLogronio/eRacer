using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class RoomManager : MonoBehaviourPunCallbacks
{
    #region Singleton

    static RoomManager _instance = null;

    public static RoomManager getInstance() 
    {
        return _instance;
    }

    #endregion

    #region Variables

    [SerializeField]
    GameObject StartButton, PlayersPanel;

    #endregion

    #region MonoBehaviour CallBacks

    void Awake()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            if (_instance == null) _instance = this;
            else Destroy(this);

            StartButton.SetActive(true);
        }
        PopulatePanel();
    }

    #endregion

    #region PUN Callbacks

    public override void OnLeftRoom()
    {
        SceneManager.LoadScene(0);
        PhotonNetwork.LeaveRoom();
    }

    public override void OnPlayerEnteredRoom(Player other)
    {
        ClearPanel();
        if (PhotonNetwork.IsMasterClient)
            PopulatePanel();
    }

    public override void OnPlayerLeftRoom(Player other)
    {
        ClearPanel();
        if (PhotonNetwork.IsMasterClient)
            PopulatePanel();
    }

    #endregion

    #region Public Methods

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    public void StartGame()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            if (PhotonNetwork.CurrentRoom.PlayerCount == PhotonNetwork.CurrentRoom.MaxPlayers)
                PhotonNetwork.LoadLevel("3-Game Scene");
            else
                Debug.Log("Fill the room before starting the game");
        }
    }

    public void ChangeTeam() 
    { 
    
    }

    #endregion

    #region Private Methods

    void ClearPanel() 
    {
        for (int i = 0; i < PlayersPanel.transform.childCount; i++) 
        {
            foreach (Transform child in PlayersPanel.transform.GetChild(i))
            {
                GameObject.Destroy(child.gameObject);
            }
        } 
    }

    void PopulatePanel() 
    {
        Debug.Log("Populating Panel");
        foreach (Player player in PhotonNetwork.CurrentRoom.Players.Values) 
        {
            GameObject panel = PhotonNetwork.Instantiate("PlayerPanelPrefab", new Vector3(0, 0, 0), Quaternion.identity);
            panel.transform.SetParent(PlayersPanel.transform.GetChild(player.ActorNumber - 1));
            panel.transform.GetChild(0).GetComponent<Text>().text = player.NickName;
            panel.transform.localPosition = Vector3.zero;
        }
    }

    #endregion

}

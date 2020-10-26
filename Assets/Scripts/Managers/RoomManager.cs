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

            GameObject panel = PhotonNetwork.Instantiate("PlayerPanelPrefab", new Vector3(0, 0, 0), Quaternion.identity);
            panel.transform.SetParent(PlayersPanel.transform.GetChild(0));
            panel.transform.GetChild(0).GetComponent<Text>().text = PhotonNetwork.NickName;
            panel.transform.localPosition = Vector3.zero;

        }
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
        // Debug.LogFormat("Player " + other.NickName + " entered the room."); // not seen if you're the player connecting
        GameObject panel = PhotonNetwork.Instantiate("PlayerPanelPrefab", new Vector3(0, 0, 0), Quaternion.identity);
        panel.transform.SetParent(PlayersPanel.transform.GetChild(PhotonNetwork.CurrentRoom.PlayerCount -1));
        panel.transform.GetChild(0).GetComponent<Text>().text = other.NickName;
        panel.transform.localPosition = Vector3.zero;
    }

    public override void OnPlayerLeftRoom(Player other)
    {
        Debug.LogFormat("Player " + other.NickName + " left the room."); // not seen if you're the player connecting

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

    #endregion

}

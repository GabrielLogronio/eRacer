using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class eRacerLobbyManager : MonoBehaviourPunCallbacks
{
    #region Static Singleton

    static eRacerLobbyManager _instance = null;
    public static eRacerLobbyManager Instance { get { return _instance;  } }

    #endregion

    #region UI Elements

    public GameObject RoomPanelPrefab;

    [SerializeField]
    Transform RoomsListContent;

    [SerializeField]
    InputField searchBar, roomNameBar;

    byte maxPlayersPerRoom = 2;

    bool searching = false;
    string searchedRoom = string.Empty;
    Dictionary<RoomInfo, GameObject> roomsInLobby;
 
    #endregion

    #region Monobehaviour Callbacks

    private void Awake()
    {
        if (_instance == null) _instance = this;
        else Destroy(this);

        roomsInLobby = new Dictionary<RoomInfo, GameObject>();
        UpdateRoomsList();
    }

    #endregion

    #region Photon Callbacks

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach (RoomInfo roomInfo in roomList)
        {
            // A room has been removed
            if (roomInfo.RemovedFromList)
            {
                Destroy(roomsInLobby[roomInfo]);
                roomsInLobby.Remove(roomInfo);
            }
            else 
            {
                // A already existing room has been updated
                if (roomsInLobby.ContainsKey(roomInfo))
                {
                    roomsInLobby[roomInfo].GetComponent<RoomInLobbyManager>().Setup(roomInfo.Name, roomInfo.PlayerCount, roomInfo.MaxPlayers);
                }
                // A new room has been created
                else 
                {
                    GameObject roomPanel = Instantiate(RoomPanelPrefab, RoomsListContent);
                    roomPanel.GetComponent<RoomInLobbyManager>().Setup(roomInfo.Name, roomInfo.PlayerCount, roomInfo.MaxPlayers);
                    roomsInLobby.Add(roomInfo, roomPanel);
                }
            }
        }
        UpdateRoomsList();
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("3 - Room Scene");
    }

    #endregion

    #region Public Methods

    public void CreateRoom() 
    {
        string roomName = roomNameBar.text;
        if (string.IsNullOrEmpty(roomName))
        {
            roomName = "Room " + Random.Range(0, 100);
        }
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = maxPlayersPerRoom; ;
        roomOptions.EmptyRoomTtl = 0;
        PhotonNetwork.CreateRoom(roomName, roomOptions);
    }

    public void JoinRoom(string roomToJoin) 
    {
        PhotonNetwork.JoinRoom(roomToJoin);
    }

    public void SearchRoom() 
    {
        searchedRoom = searchBar.text;
        searching = true;
        UpdateRoomsList();
    }

    public void ResetSearch() 
    {
        searchedRoom = string.Empty;
        searchBar.text = string.Empty;
        searching = false;
        UpdateRoomsList();
    }

    #endregion

    #region Utility Methods

    void UpdateRoomsList() 
    {
        foreach (RoomInfo roomInfo in roomsInLobby.Keys) 
        {
            if (searching)
            {
                if (roomInfo.Name.Contains(searchedRoom)) roomsInLobby[roomInfo].SetActive(true);
                else roomsInLobby[roomInfo].SetActive(false);
            }
            else 
            {
                if (roomInfo.PlayerCount < roomInfo.MaxPlayers) roomsInLobby[roomInfo].SetActive(true);
                else roomsInLobby[roomInfo].SetActive(false);
            }
        }
    }

    #endregion

}

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using Photon.Pun;
using Photon.Realtime;

public class eRacerRoomManager : MonoBehaviourPunCallbacks
{
    #region Static Singleton

    static eRacerRoomManager _instance = null;
    public static eRacerRoomManager Instance { get { return _instance; } }

    #endregion

    Dictionary<Player, GameObject> playersInRoom;
    ExitGames.Client.Photon.Hashtable customProperties = new ExitGames.Client.Photon.Hashtable();

    #region UI Elements

    public GameObject PlayerPanelPrefab;

    [SerializeField]
    Transform PlayersListContent;

    [SerializeField]
    Text roomNameText, ownerText;

    [SerializeField]
    GameObject StartButton;

    #endregion

    #region Monobehaviour Callbacks

    private void Awake()
    {
        if (_instance == null) _instance = this;
        else Destroy(this);

        playersInRoom = new Dictionary<Player, GameObject>();
        PopulatePlayersPanel();

        if (!PhotonNetwork.IsMasterClient) StartButton.SetActive(false);

        roomNameText.text = "Room: " + PhotonNetwork.CurrentRoom.Name;
        ownerText.text = "owned by \"" + PhotonNetwork.CurrentRoom.Players[PhotonNetwork.CurrentRoom.MasterClientId].NickName + "\"";

    }

    #endregion

    #region Photon Callbacks

    void PopulatePlayersPanel()
    {
        playersInRoom = new Dictionary<Player, GameObject>();

        foreach (Transform child in PlayersListContent.gameObject.transform)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++) 
        {
            Player player = PhotonNetwork.PlayerList[i];
            GameObject playerPanel = Instantiate(PlayerPanelPrefab, PlayersListContent);
            playerPanel.GetComponent<PlayerInRoomManager>().Setup(player);
            playersInRoom.Add(player, playerPanel);
        }
    }

    public override void OnLeftRoom()
    {
        PhotonNetwork.JoinLobby();
        SceneManager.LoadScene(1);

    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        PopulatePlayersPanel();
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        PopulatePlayersPanel();
    }

    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        ownerText.text = "owned by \"" + newMasterClient.NickName + "\"";
    }

    public override void OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
    {
        playersInRoom[targetPlayer].GetComponent<PlayerInRoomManager>().PlayerSwitched((int)changedProps["team"]);
    }

    #endregion

    #region Public Methods

    public void KickPlayer(GameObject playerToKick) 
    {
        if (PhotonNetwork.IsMasterClient) 
        {
            foreach (KeyValuePair<Player, GameObject> playerInfo in playersInRoom) 
            { 
                // USE RPC WITH LEAVE ROOM, IF PLAYER.NAME == PLAYERTOKICK
                //if(playerToKick.Equals(playerInfo.Value))
                //    PhotonNetwork.CurrentRoom.leave
            }
        }
    }

    public void SwitchTeam(Player playerSwitchingTeam, int newTeam) 
    {
        if (playerSwitchingTeam.IsLocal) 
        {
            customProperties["team"] = newTeam;
            PhotonNetwork.LocalPlayer.SetCustomProperties(customProperties);
        }
    }

    public void ExitGame() 
    {
        PhotonNetwork.LeaveRoom();
    }

    public void StartGame() 
    {
        if (PhotonNetwork.IsMasterClient && PhotonNetwork.CurrentRoom.PlayerCount == PhotonNetwork.CurrentRoom.MaxPlayers) 
        {
            int blueTeamPlayers = 0, redTeamPlayers = 0;
            foreach (Player player in PhotonNetwork.CurrentRoom.Players.Values)
            {
                switch (player.CustomProperties["team"])
                {
                    case 0:
                        blueTeamPlayers++;
                        break;
                    case 1:
                        redTeamPlayers++;
                        break;
                }
            }
            if (blueTeamPlayers == redTeamPlayers)
                PhotonNetwork.LoadLevel("4 - Team Scene");
        }
    }

    #endregion

}

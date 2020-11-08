using UnityEngine;

using Photon.Pun;
using Photon.Realtime;

public class eRacerPlayer : MonoBehaviourPunCallbacks
{
    static eRacerPlayer local = null;
    public static eRacerPlayer Local { get { return local; } }

    #region Player attributes

    ExitGames.Client.Photon.Hashtable customProperties = new ExitGames.Client.Photon.Hashtable();
    string playerNickname = string.Empty, roomID = string.Empty;
    int playerID = -1, playerTeam = -1;
    GameObject ingameRacer = null;

    #endregion

    #region Monobehaviour Callbacks

    private void Awake()
    {
        if (local == null) 
        {
            local = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);

    }

    #endregion

    #region Photon Callbacks

    public override void OnConnectedToMaster() 
    {
        PhotonNetwork.LocalPlayer.NickName = playerNickname;
        customProperties["team"] = 0;
        PhotonNetwork.LocalPlayer.CustomProperties = customProperties;
    }

    public override void OnJoinedRoom()
    {
        playerID = PhotonNetwork.LocalPlayer.ActorNumber;
        roomID = PhotonNetwork.CurrentRoom.Name;
    }

    public override void OnLeftRoom()
    {
        playerID = -1;
        roomID = string.Empty;
    }

    #endregion

    #region Public Methods

    public void ChangeNickname(string toSetNickname) 
    {
        playerNickname = toSetNickname;
    }

    public void ChangeTeam(int newTeam) 
    {
        playerTeam = newTeam;
    }

    #endregion

}

using UnityEngine;
using UnityEngine.UI;

using Photon.Pun;
using Photon.Realtime;

public class LauncherManager : MonoBehaviourPunCallbacks
{
    #region Variables

    [Tooltip("The maximum number of players per room. When a room is full, it can't be joined by new players, and so new room will be created")]
    [SerializeField]
    private byte maxPlayersPerRoom = 10;

    [Tooltip("The Ui Panel to let the user enter name, connect and play")]
    [SerializeField]
    private GameObject launcherPanel = null;

    [Tooltip("The UI Label to inform the user that the connection is in progress")]
    [SerializeField]
    private Text progressText = null;

    #endregion

    #region MonoBehaviour CallBacks

    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;

        PhotonNetwork.ConnectUsingSettings();

    }

    #endregion

    #region Public Methods

    public void CreateGame() 
    {
        launcherPanel.SetActive(false);
        progressText.text = "Creating the game...";

        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = maxPlayersPerRoom });
    }

    public void JoinGame() 
    {
        launcherPanel.SetActive(false);
        progressText.text = "Joining a game...";

        PhotonNetwork.JoinRandomRoom();
    }

    public void CloseLauncher() 
    {
        PhotonNetwork.Disconnect();
        Application.Quit();
    }

    #endregion;

    #region PUN Callbacks
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");

        launcherPanel.SetActive(true);
        progressText.text = "Connected!";

    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        launcherPanel.SetActive(true);
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        launcherPanel.SetActive(true);
        progressText.text = "No game found.";
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Now this client is in a room.");

        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {
            PhotonNetwork.LoadLevel("2-Room Scene");
        }
    }

    #endregion
}

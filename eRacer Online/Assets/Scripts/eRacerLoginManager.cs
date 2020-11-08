using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class eRacerLoginManager : MonoBehaviourPunCallbacks
{
    #region UI Elements

    [SerializeField]
    InputField nicknameInputField;
    [SerializeField]
    Text errorText;
    [SerializeField]
    GameObject errorPanel;

    #endregion

    bool nicknameSet = false;

    #region Photon Callbacks

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();

        PhotonNetwork.LoadLevel("2 - Lobby Scene");
    }

    #endregion

    #region Public Methods

    public void ChangeNickname(string toSetNickname) 
    {
        if (!string.IsNullOrEmpty(toSetNickname))
        {
            if (toSetNickname.Length <= 16 && toSetNickname.Length >= 3)
            {
                errorPanel.SetActive(false);
                nicknameSet = true;
                eRacerPlayer.Local.ChangeNickname(toSetNickname);
            }
            else Error("The Nickname must be 3-16 characters long");
        }
        else Error("The Nickname can't be empty.");
    }

    public void ConnectToPhotonServer()
    {
        if (nicknameSet) 
        {
            PhotonNetwork.AutomaticallySyncScene = true;
            PhotonNetwork.ConnectUsingSettings();
        }
        else
        {
            Error("There's been an error with the Nickname.");
        }
    }

    #endregion

    #region Utility methods

    void Error(string toPrint) 
    {
        nicknameSet = false;
        errorText.text = toPrint;
        errorPanel.SetActive(true);
    }

    #endregion
}

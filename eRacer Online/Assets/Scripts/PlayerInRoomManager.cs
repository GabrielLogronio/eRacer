using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon;
using Photon.Pun;
using Photon.Realtime;

public class PlayerInRoomManager : MonoBehaviour
{
    [SerializeField]
    Text playerNameText;

    [SerializeField]
    GameObject kickButton, bluTeamButton, redTeamButton;

    Player player;

    public void Setup(Player toSetPlayer) 
    {
        playerNameText.text = toSetPlayer.NickName;
        player = toSetPlayer;

        PlayerSwitched((int) toSetPlayer.CustomProperties["team"]);

        if (!PhotonNetwork.IsMasterClient) 
        {
            kickButton.SetActive(false);
        }
        if (!player.IsLocal) 
        {
            bluTeamButton.GetComponent<Button>().interactable = false;
            redTeamButton.GetComponent<Button>().interactable = false;
        }
    }

    public void SwitchTeam(int teamID) 
    {
        if (player == PhotonNetwork.LocalPlayer)
        {
            eRacerRoomManager.Instance.SwitchTeam(player, teamID);
        }
    }

    public void PlayerSwitched(int newTeam) 
    {
        switch (newTeam)
        {
            case 0:
                redTeamButton.SetActive(false);
                bluTeamButton.SetActive(true);
                break;
            case 1:
                redTeamButton.SetActive(true);
                bluTeamButton.SetActive(false);
                break;
        }
    }

    public void KickFromRoom() 
    {
        eRacerRoomManager.Instance.KickPlayer(gameObject);
    }

}

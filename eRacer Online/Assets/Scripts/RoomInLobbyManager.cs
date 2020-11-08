using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomInLobbyManager : MonoBehaviour
{
    [SerializeField]
    Text roomNameText, roomPlayersText;

    public void Setup(string roomName, int currentPlayers, int maxPlayers) 
    {
        roomNameText.text = roomName;
        roomPlayersText.text = currentPlayers + "/" + maxPlayers;
    }

    public string roomName() 
    {
        return roomNameText.text;
    }

    public void JoinRoom() 
    {
        eRacerLobbyManager.Instance.JoinRoom(roomNameText.text);
    }
}

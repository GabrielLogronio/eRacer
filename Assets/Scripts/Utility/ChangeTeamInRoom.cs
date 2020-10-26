using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// DA COMPLETARE
public class ChangeTeamInRoom : MonoBehaviour
{

    public void ChangeTeam()
    {
        RoomManager.getInstance().ChangeTeam();    
    }
}

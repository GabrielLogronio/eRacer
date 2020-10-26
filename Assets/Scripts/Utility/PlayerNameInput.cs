using System.Collections;
using System.Collections.Generic;

using Photon.Pun;
using Photon.Realtime;

using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class PlayerNameInput : MonoBehaviour
{
    #region Private Constants

    #endregion

    #region MonoBehaviour CallBacks

    void Start()
    {
        string defaultName = string.Empty;
        InputField _inputField = this.GetComponent<InputField>();
        if (_inputField != null)
        {
            PhotonNetwork.NickName = defaultName;
        }
    }

    #endregion

    #region Public Methods

    public void SetPlayerName(string value)
    {
        DebugText.getInstance().Output("Name " + value);

        // #Important
        if (string.IsNullOrEmpty(value))
        {
            Debug.LogError("Player Name is null or empty");
            return;
        }
        PhotonNetwork.NickName = value;
    }
    #endregion
}

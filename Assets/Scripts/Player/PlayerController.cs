using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Photon.Pun;

public class PlayerController : MonoBehaviourPun
{
    #region Variables

    Animator anim;
    float speed = 5f;

    #endregion

    #region MonoBehaviour Callbacks

    void Start()
    {
        anim = transform.GetChild(0).GetChild(0).GetComponent<Animator>();
    }

    void Update()
    {
        if (photonView.IsMine && PhotonNetwork.IsConnected == true)
        {
            if (Input.GetMouseButton(2))
                transform.Translate(transform.forward * Time.deltaTime * speed);
            if (Input.GetMouseButtonDown(1))
                anim.SetBool("Victory", !anim.GetBool("Victory"));
            if (Input.GetMouseButtonDown(0))
                anim.SetTrigger("Ability");
        }
    }

    #endregion


}

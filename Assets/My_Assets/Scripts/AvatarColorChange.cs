using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarColorChange : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Material[] changeColor;

    private void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                photonView.RPC(nameof(ChangeColorRPC), RpcTarget.AllBuffered, 0);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                photonView.RPC(nameof(ChangeColorRPC), RpcTarget.AllBuffered, 1);
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                photonView.RPC(nameof(ChangeColorRPC), RpcTarget.AllBuffered, 2);
            }
        }
    }

    [PunRPC]
    public void ChangeColorRPC(int target)
    {
        GetComponent<Renderer>().material = changeColor[target];
    }
}
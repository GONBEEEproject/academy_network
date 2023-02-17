using Photon.Pun;
using UnityEngine;

public class AvatarMove : MonoBehaviourPunCallbacks
{
    void Update()
    {
        if (photonView.IsMine)
        {
            Vector3 input = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Input.GetAxis("Vertical") * Time.deltaTime);
            transform.position += input;
        }
    }
}
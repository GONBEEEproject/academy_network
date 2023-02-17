using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject avatar;

    [SerializeField]
    private GameObject[] avatarList;

    [SerializeField]
    private GameObject avatarSelectUI;

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        avatarSelectUI.SetActive(false);
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        //Vector3 pos = new Vector3(Random.Range(-3f, 3f), 0, Random.Range(-3f, 3f));
        //PhotonNetwork.Instantiate(avatar.name, pos, Quaternion.identity);

        avatarSelectUI.SetActive(true);
    }

    public void AvatarSelect(int num)
    {
        Vector3 pos = new Vector3(Random.Range(-3f, 3f), 0, Random.Range(-3f, 3f));
        PhotonNetwork.Instantiate(avatarList[num].name, pos, Quaternion.identity);
        avatarSelectUI.SetActive(false);
    }
}
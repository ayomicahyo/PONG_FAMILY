using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class RoomManager : MonoBehaviour
{
    public GameObject mainRoom;
    public GameObject createRoom;
    public GameObject joinRoom;
    public GameObject lobby;
    public GameObject waitJoin;

    public InputField p1Name;

    void Start()
    {
 
    }

    public void CreateRoom()
    {
        if(mainRoom.active == true)
        {
            createRoom.SetActive(true);
            mainRoom.SetActive(false);
        }
    }

    public void JoinRoom()
    {
        if (mainRoom.active == true)
        {
            joinRoom.SetActive(true);
            mainRoom.SetActive(false);
        }
    }

    public void Lobby()
    {
        if(createRoom.active == true)
        {
            lobby.SetActive(true);
            createRoom.SetActive(false);
        }
    }

    public void WaitingJoin()
    {
        if(joinRoom.active == true)
        {
            waitJoin.SetActive(true);
            joinRoom.SetActive(false);
        }
    }


    ////////////////////////////// Network Area///////////////////////////

}
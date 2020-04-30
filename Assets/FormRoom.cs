using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class FormRoom : MonoBehaviour
{
    public InputField nameHost;
    public LobbyManager lobbyManager;

    public void OnClick()
    {
        lobbyManager.StartMatchMaker();
        lobbyManager.matchMaker.CreateMatch(nameHost.text, (uint)lobbyManager.maxPlayers, true, "", "", "", 0, 0, lobbyManager.OnMatchCreate);
    }
}

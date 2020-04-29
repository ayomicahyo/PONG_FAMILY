using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DBBracket")]
public class DBBracket : ScriptableObject
{
    public int numOfPlayer;
	public bool pt1,pt2,winL,winR;
	public string[] nameOfPlayer;
	
	public string player1Active;
	public string player2Active;
}

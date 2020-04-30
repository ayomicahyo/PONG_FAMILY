using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class awake : MonoBehaviour
{
	public DBBracket thatBracket;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void Player1Win(){
		if(thatBracket.numOfPlayer == 4){
			thatBracket.nameOfPlayer[0] = thatBracket.player1Active;
			thatBracket.nameOfPlayer[1] = thatBracket.nameOfPlayer[2];
			thatBracket.nameOfPlayer[2] = thatBracket.nameOfPlayer[3];
		}
		if(thatBracket.numOfPlayer == 3){
			thatBracket.nameOfPlayer[1] = thatBracket.player1Active;
		}
		if(thatBracket.numOfPlayer == 2){
			thatBracket.nameOfPlayer[0] = thatBracket.player1Active;
		}
		thatBracket.numOfPlayer -= 1;
		//SceneManager.LoadScene("Bracket");
	}
	
	public void Player2Win(){
		if(thatBracket.numOfPlayer == 4){
			thatBracket.nameOfPlayer[0] = thatBracket.player2Active;
			thatBracket.nameOfPlayer[1] = thatBracket.nameOfPlayer[2];
			thatBracket.nameOfPlayer[2] = thatBracket.nameOfPlayer[3];
		}
		if(thatBracket.numOfPlayer == 3){
			thatBracket.nameOfPlayer[1] = thatBracket.player2Active;
		}
		if(thatBracket.numOfPlayer == 2){
			thatBracket.nameOfPlayer[0] = thatBracket.player2Active;
		}
		thatBracket.numOfPlayer -= 1;
		//SceneManager.LoadScene("Bracket");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : MonoBehaviour
{
	public DBBracket thisDBBracket;
	public Text textP1;
	public Text textP2;
	void Awake(){
		if(thisDBBracket.winL){
			textP1.text = thisDBBracket.nameOfPlayer[1];
			textP2.text = thisDBBracket.nameOfPlayer[2];
		}
		if(thisDBBracket.winL && thisDBBracket.winR){
			textP1.text = thisDBBracket.nameOfPlayer[0];
			textP2.text = thisDBBracket.nameOfPlayer[1];
		}
		if(thisDBBracket.winL == false && thisDBBracket.winR == false){
			textP1.text = thisDBBracket.nameOfPlayer[0];
			textP2.text = thisDBBracket.nameOfPlayer[1];
		}
	}
    // Start is called before the first frame update
    public void SetGameplay()
    {
        thisDBBracket.player1Active = textP1.text;
		thisDBBracket.player2Active = textP2.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

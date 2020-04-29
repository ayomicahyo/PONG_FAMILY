using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : MonoBehaviour
{
	public DBBracket thisDBBracket;
	public Text textP1;
	public Text textP2;
	private bool p1,p2,p3,p4;
	void Awake(){
		p1 =false;
		p2 =false;
		p3 =false;
		p4 =false;
		if(thisDBBracket.winL){
			textP1.text = thisDBBracket.nameOfPlayer[1];
			textP2.text = thisDBBracket.nameOfPlayer[2];
			p2 = true;
			p3 = true;
		}
		if(thisDBBracket.winL && thisDBBracket.winR){
			textP1.text = thisDBBracket.nameOfPlayer[0];
			textP2.text = thisDBBracket.nameOfPlayer[1];
			p1=true;
			p2=true;
		}
		if(thisDBBracket.winL == false && thisDBBracket.winR == false){
			textP1.text = thisDBBracket.nameOfPlayer[0];
			textP2.text = thisDBBracket.nameOfPlayer[1];
			p1=true;
			p2=true;
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

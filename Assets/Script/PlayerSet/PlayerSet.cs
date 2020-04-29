using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSet : MonoBehaviour
{
	public DBBracket thatDBbracket;
	public int numPlayer = 0;
	public InputField[] inputBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void Player1v1(){
		numPlayer = 2;
		SetNametoDB();
	}
	
	public void Playeris3(){
		numPlayer = 3;
		SetNametoDB();
	}
	
	public void Playeris4(){
		numPlayer = 4;
		SetNametoDB();
	}
	
	void SetNametoDB(){
		thatDBbracket.numOfPlayer = numPlayer;
	}
	
	public void GoToBracket(){
		for(int i = 0; i<4 ;i++){
			thatDBbracket.nameOfPlayer[i] = inputBox[i].text;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BracketSystem : MonoBehaviour
{
	public AudioSource sound;
	public AudioClip winner;
	public GameObject buttonDone;
	public GameObject buttonFight;
	public GameObject dOne;
	public bool isDONE;
	public DBBracket thisBracket;
	public string[] playernameSet;
    public int playerSet;
	[SerializeField] private GameObject[] bracketPlayer = new GameObject[7];
	[SerializeField] private Text[] textName = new Text[7];
	public bool wL,wR,wF;
	public GameObject fight,theWinner;
	public Text nameWinner;
	//anjay
	
	void Awake(){
		isDONE = false;
		wL=false;
		wR=false;
		wF=false;
		playerSet = thisBracket.numOfPlayer;
		for(int i=0;i<7;i++){
			bracketPlayer[i] = GameObject.Find("Bracket"+i.ToString());
		}
		for (int i=0;i<4;i++){
			playernameSet[i] = thisBracket.nameOfPlayer[i];
			textName[i].text = playernameSet[i]; 
		}
		if(playerSet == 3){
			bracketPlayer[0].SetActive(false);
			bracketPlayer[1].SetActive(false);
			textName[4].text = playernameSet[0];
			textName[2].text = playernameSet[1];
			textName[3].text = playernameSet[2];
			wL = true;
		}
		if(playerSet == 2){
			bracketPlayer[0].SetActive(false);
			bracketPlayer[1].SetActive(false);
			bracketPlayer[2].SetActive(false);
			bracketPlayer[3].SetActive(false);
			textName[4].text = playernameSet[0];
			textName[5].text = playernameSet[1];
			wL=true;
			wR=true;
		}
		if(playerSet == 1){
			bracketPlayer[0].SetActive(false);
			bracketPlayer[1].SetActive(false);
			bracketPlayer[2].SetActive(false);
			bracketPlayer[3].SetActive(false);
			bracketPlayer[4].SetActive(false);
			bracketPlayer[5].SetActive(false);
			textName[6].text = playernameSet[0];
			
		}
		thisBracket.winL = wL;
		thisBracket.winR = wR;
		if(playerSet == 1){
			sound.PlayOneShot(winner);
			buttonFight.SetActive(false);
			buttonDone.SetActive(true);
			isDONE = true;
			fight.SetActive(false);
			theWinner.SetActive(true);
			nameWinner.text = thisBracket.nameOfPlayer[0];
		}
		if(isDONE){
			dOne.SetActive(true);
		}
	}
	
	public void TurnDecrease(){
		playerSet -=1;
	}
}

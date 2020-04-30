using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollScore : MonoBehaviour
{
	private Gameplaymanager manager;
    public bool isPlayer1;
	public Text scoretext1;
	public Text scoretext2;
	
	void Start(){
		manager = GameObject.Find("EventSystem").GetComponent<Gameplaymanager>();
	}
	void OnTriggerEnter2D(Collider2D coll){
		
		if(coll.gameObject.name =="BALL(Clone)"|| coll.gameObject.name =="BALL 1(Clone)"){
			manager.sound.PlayOneShot(manager.goalSound);
			Destroy(coll.gameObject);
			if(isPlayer1){
				manager.scoreP1 += 1;
				scoretext1.text = manager.scoreP1.ToString();
			}
			else{
				manager.scoreP2 +=1;
				scoretext2.text = manager.scoreP2.ToString();
			}
			manager.ballInArena -= 1;
		}else if(coll.gameObject.name =="BALL 2(Clone)"|| coll.gameObject.name =="BALL 3(Clone)" ){
			manager.sound.PlayOneShot(manager.goalSound);
			Destroy(coll.gameObject);
			if(isPlayer1){
				manager.scoreP1 += 1;
				scoretext1.text = manager.scoreP1.ToString();
			}
			else{
				manager.scoreP2 +=1;
				scoretext2.text = manager.scoreP2.ToString();
			}
			manager.ballInArena -= 1;
		}
	}
}

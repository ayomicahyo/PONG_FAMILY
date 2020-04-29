using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
	public bool isPlayer1;
	public float speed = 4f;
	private GameObject skillSpawn;
	private int i;
	ButtonJurus player1,player2;
	Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
		i=0;
		player1 = GameObject.Find("Jurus Yang Didapet P1").GetComponent<ButtonJurus>();
		player2 = GameObject.Find("Jurus Yang Didapet P2").GetComponent<ButtonJurus>();
		skillSpawn = GameObject.Find("Skill Spawn");
		rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,speed*1);
    }

    void OnTriggerEnter2D(Collider2D coll){
		
		if(coll.gameObject.name =="Box1" || coll.gameObject.name =="Box2"){
			Destroy(gameObject);
			skillSpawn.SetActive(false);
			i = Random.Range(1,4);
			if(isPlayer1){
				if(i==1){
					player1.skill1 = true;
					player1.skill2 = false;
					player1.skill3 = false;
				}
				if(i==2){
					player1.skill1 = false;
					player1.skill2 = true;
					player1.skill3 = false;
				}
				if(i==3){
					player1.skill1 = false;
					player1.skill2 = false;
					player1.skill3 = true;
				}
			}else{
				if(i==1){
					player2.skill1 = true;
					player2.skill2 = false;
					player2.skill3 = false;
				}
				if(i==2){
					player2.skill1 = false;
					player2.skill2 = true;
					player2.skill3 = false;
				}
				if(i==3){
					player2.skill1 = false;
					player2.skill2 = false;
					player2.skill3 = true;
				}
			}
		}
		if(coll.gameObject.name =="BAtAS ATAS" || coll.gameObject.name =="BAtAS BAWAH" ){
			Destroy(gameObject);
		}
	}
}

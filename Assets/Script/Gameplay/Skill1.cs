using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill1 : MonoBehaviour
{
	public bool isplayer1;
    public float speed = 4f;
	Rigidbody2D rb;
	public GameObject player1,player2;
	public Sprite bullet;
    // Start is called before the first frame update
    void Start()
    {
		player1 = GameObject.Find("C p1 tempat jari");
		player2 = GameObject.Find("C p2 tempat jari");
		if(!isplayer1){
			speed = -speed;
		}
		rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,speed*1);
    }

    void OnTriggerEnter2D(Collider2D coll){
		
		if(coll.gameObject.name == "Collider2"){
			player2.SetActive(false);
		}
		if(coll.gameObject.name == "Collider1"){
			player1.SetActive(false);
		}
		if(coll.gameObject.name == "BAtAS ATAS" || coll.gameObject.name == "BAtAS BAWAH" ){
			Destroy(gameObject);
			player2.SetActive(true);
			player1.SetActive(true);
			if(!isplayer1){
				GameObject.Find("jurusA").GetComponent<Image>().sprite = bullet;
			}else{
				GameObject.Find("jurusB").GetComponent<Image>().sprite = bullet;
			}
		}
	}
	
}

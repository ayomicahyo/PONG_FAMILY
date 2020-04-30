using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonJurus : MonoBehaviour
{
	public bool isPlayer1;
	public bool bullet= true;
	public bool skill1= false;
	public bool skill2= false;
	public bool skill3= false;
	public GameObject wall1,wall2;
	public GameObject shootPoint,shootPoint2,skill1b,skill1b2;
	
	public GameObject character1,cCollider1,character2,cCollider2;
	RectTransform rt1,rt2;
	public Vector2 c1scalechange;
	
	
	public GameObject bull,bull2;
  
	void Start(){
		rt1 = character1.GetComponent<RectTransform>();
		rt2 = character2.GetComponent<RectTransform>();
		wall1.SetActive(false);
		wall2.SetActive(false);
	}
	
	public void Seleksi(){
		if(bullet){
			Bullet();
		}
		if(skill1){
			SKILL1();
		}
		if(skill2){
			SKILL2();
		}
		if(skill3){
			SKILL3();
		}
		
	}
    void Bullet(){
		if(isPlayer1){
			Instantiate(bull, shootPoint.transform.position, Quaternion.identity);
		}else{
			Instantiate(bull2, shootPoint2.transform.position, Quaternion.identity);
		}
	}
	
	void SKILL1(){
		if(isPlayer1){
			Instantiate(skill1b, shootPoint.transform.position, Quaternion.identity);
		}else{
			Instantiate(skill1b2, shootPoint2.transform.position, Quaternion.identity);
		}
		bullet = true;
		skill1 = false;
		skill2 = false;
		skill3 = false;
	}
	void SKILL2(){
		if(isPlayer1){
			wall1.SetActive(true);
			StartCoroutine(Wait(3f));
		}else{
			wall2.SetActive(true);
			StartCoroutine(Wait(3f));
		}
		bullet = true;
		skill1 = false;
		skill2 = false;
		skill3 = false;
	}
	void SKILL3(){
		if (isPlayer1){
			rt1.sizeDelta = new Vector2(400f,400f);
			cCollider1.transform.localScale = new Vector2(1800f,300f);
			StartCoroutine(Wait(3f));
		}else{
			rt2.sizeDelta = new Vector2(400f,400f);
			cCollider2.transform.localScale = new Vector2(1800f,300f);
			StartCoroutine(Wait(3f));
		}
		bullet = true;
		skill1 = false;
		skill2 = false;
		skill3 = false;
	}
	
	IEnumerator Wait(float time){
		yield return new WaitForSeconds(time);
		wall1.SetActive(false);
		wall2.SetActive(false);
		rt1.sizeDelta = new Vector2(188.4f,188.4f);
		cCollider1.transform.localScale = new Vector2(833.47f,300f);
		rt2.sizeDelta = new Vector2(188.4f,188.4f);
		cCollider2.transform.localScale = new Vector2(833.47f,300f);
	}
}

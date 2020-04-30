using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class transisi : MonoBehaviour
{
	private Gameplaymanager manager;
	private Animator charAnimator;
	private GameObject thisTrans;
	public bool isGameplay;
	public Text ready1,ready2;
	public GameObject r1,r2;
	float timeBtwSpawn = 2f;
    // Start is called before the first frame update
    void Start()
    {
		manager = GameObject.Find("EventSystem").GetComponent<Gameplaymanager>();
        charAnimator = GetComponent<Animator>();
		thisTrans = GameObject.Find("transisi");
		if(isGameplay){
			manager.sound.PlayOneShot(manager.readyFight);
			isGameplay =false;
		}
		TransisiIn();
		
    }

	void Update(){
		if(isGameplay){
			if (timeBtwSpawn <= 0)
			{
				manager.sound.PlayOneShot(manager.readyFight);
				ready1.text = "FIGHT!!";
				ready2.text = "FIGHT!!";
				isGameplay = false;
			}
			else
			{
				timeBtwSpawn -= Time.deltaTime;
			}
		}
	}
    // Update is called once per frame
	public void TransisiIn(){
		
		charAnimator.SetBool("isTransisiIN",true);
		StartCoroutine(Waiting(1.5f));
		
	}
	
	public void TransisiOut(){
		
		thisTrans.SetActive(true);
		charAnimator.SetBool("isTransisiOUT",true);
		StartCoroutine(Waiting(3f));
	}
	
	IEnumerator Waiting(float time)
    {
        yield return new WaitForSeconds(time);;
		charAnimator.SetBool("isTransisiIN",false);
		charAnimator.SetBool("isTransisiOUT",false);
		thisTrans.SetActive(false);
		r2.SetActive(false);
		r1.SetActive(false);
    }
	
}

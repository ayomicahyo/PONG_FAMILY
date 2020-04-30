using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplaymanager : MonoBehaviour
{
	public AudioSource sound;
	public AudioClip spawnsound;
	public AudioClip hitSound;
	public AudioClip goalSound;
	public AudioClip winSound;
	public AudioClip readyFight;
	public bool gameIsplay;
    public bool doSpawn = true;
	public int ballInArena=0;
	public int scoreP1=0;
	public int scoreP2=0;
	public float timeBtwSpawn;
	private GameObject skillSpawner;
	private float startTimeBtwSpawn= 4f;
	public bool skillfield;
	public GameObject spawnerupleft,spawnerupright,spawnerbotleft,spawnerbotright;
	private BallSpawner aturspawner1,aturspawner2,aturspawner3,aturspawner4;
	private int i;
	void Start(){
		gameIsplay = true;
		i=0;
		aturspawner1 = spawnerupleft.GetComponent<BallSpawner>();
		aturspawner2 = spawnerupright.GetComponent<BallSpawner>();
		aturspawner3 = spawnerbotleft.GetComponent<BallSpawner>();
		aturspawner4 = spawnerbotright.GetComponent<BallSpawner>();
		skillfield=false;
		skillSpawner = GameObject.Find("Skill Spawn");
		skillSpawner.SetActive(false);
		
	}
	
	public void Kocok(){
		sound.PlayOneShot(spawnsound);
		Debug.Log(i.ToString());
		if(i==1){
			aturspawner1.Spawning();
		}else
		if(i==2){
			aturspawner2.Spawning();
		}else
		if(i==3){
			aturspawner3.Spawning();
		}else{
			aturspawner4.Spawning();
		}
		i = 0;
		Debug.Log(i.ToString());
	}
	
	void Update(){
		
			if (timeBtwSpawn <= 0)
			{
				i = Random.Range(1,4);
				if(ballInArena != 5 && gameIsplay == true){
					Kocok();
				}
				if(skillfield){
					skillSpawner.SetActive(false);
					skillfield = false;
				}else{
					skillSpawner.SetActive(true);
					skillfield = true;
				}
				timeBtwSpawn = startTimeBtwSpawn;
			}
			else
			{
				timeBtwSpawn -= Time.deltaTime;
			}
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
	
	public int time;
	public Text textTime1,textTime2,winnerText;
	private float timeBtwSpawn = 1f;
	private float startTimeBtwSpawn = 1f;
	public GameObject done;
	private Gameplaymanager manager;
	private awake itsAwake;
    // Start is called before the first frame update
    void Start()
    {
		done.SetActive(false);
		itsAwake = GameObject.Find("EventSystem").GetComponent<awake>();
		manager = GameObject.Find("EventSystem").GetComponent<Gameplaymanager>();
        textTime1.text = time.ToString();
		textTime2.text = time.ToString();
    }

    // Update is called once per frame
    void Update()
    {
		if(manager.gameIsplay){
			if (timeBtwSpawn <= 0)
			{
				time -= 1;
				textTime1.text = time.ToString();
				textTime2.text = time.ToString();
				timeBtwSpawn = startTimeBtwSpawn;
				}
				else
				{
					timeBtwSpawn -= Time.deltaTime;
			}
			if( time <= 0 ){
				Debug.Log("gameSelesai");
				manager.sound.PlayOneShot(manager.winSound);
				manager.gameIsplay = false;
				done.SetActive(true);
				if(manager.scoreP1 > manager.scoreP2){
					winnerText.text = "PLAYER 1 WIN";
					itsAwake.Player1Win();
				}else{
					winnerText.text = "PLAYER 2 WIN";
					itsAwake.Player2Win();
				}
			}
		}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	public bool spawn;
	Gameplaymanager gameManager;
	public GameObject bola;
    // Start is called before the first frame update
    void Start()
    {
		spawn = false;
        gameManager = GameObject.Find("EventSystem").GetComponent<Gameplaymanager>();
    }

    // Update is called once per frame
	public void Spawning(){
		Instantiate(bola, transform.position, Quaternion.identity); // Spawn Bola
		gameManager.ballInArena +=1;
		spawn=false;
	}
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class COBA : MonoBehaviour
{
	public DB thisDb;
	private GameManager thisManager;
	
	void Awake(){
		thisManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
    public void Gantiisi(){
		thisDb.name = "CAHYO";
		
		thisManager.nama = thisDb.name;
	}
	
	public void Gantiscene(){
		SceneManager.LoadScene("GamePlay");
	}
}

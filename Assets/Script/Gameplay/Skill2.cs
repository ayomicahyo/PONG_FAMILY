using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill2 : MonoBehaviour
{
    public bool isplayer1;
	public GameObject wallplayer1,wallplayer2;
    // Start is called before the first frame update
    void Start()
    {
		wallplayer1 = GameObject.Find("wallP1");
		wallplayer2 = GameObject.Find("wallP2");
		wallplayer1.SetActive(false);
    }

    public void WallP1(){
		wallplayer1.SetActive(true);
		StartCoroutine(Wait(3f));
	}
	
	public void WallP2(){
		wallplayer2.SetActive(true);
		StartCoroutine(Wait(3f));
	}
	
	IEnumerator Wait(float time){
		yield return new WaitForSeconds(time);
		wallplayer1.SetActive(false);
		wallplayer2.SetActive(false);
	}
}
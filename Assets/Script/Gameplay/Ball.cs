using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public float speed;
	private Rigidbody2D rb;
	public bool isUPleft;
	public bool isUPRight;
	public bool isDownLeft;
	public bool isDownRight;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		if(isUPRight){
			LaunchBallRightUP();
		}
		if(isUPleft){
			LaunchBallLeftUP();
		}
		if(isDownLeft){
			LaunchBallLeftDown();
		}
		if(isDownRight){
			LaunchBallRightDown();
		}
    }

    // Update is called once per frame
    private void LaunchBallRightUP(){
		float x = Random.Range(0f,-2f);
		float y = Random.Range(0f,-2f);
		rb.velocity = new Vector2(speed*x,speed*y);
	}
	
	private void LaunchBallLeftDown(){
		float x = Random.Range(0f,2f);
		float y = Random.Range(0f,2f);
		rb.velocity = new Vector2(speed*x,speed*y);
	}
	private void LaunchBallLeftUP(){
		float x = Random.Range(0f,2f);
		float y = Random.Range(0f,-2f);
		rb.velocity = new Vector2(speed*x,speed*y);
	}
	
	private void LaunchBallRightDown(){
		float x = Random.Range(0f,-2f);
		float y = Random.Range(0f,2f);
		rb.velocity = new Vector2(speed*x,speed*y);
	}
	
	
}

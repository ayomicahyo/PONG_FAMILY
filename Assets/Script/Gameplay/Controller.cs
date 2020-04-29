using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	private float deltaX,deltaY;
	Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	void OnMouseDown(){
		deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
		deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
	}
	
	void OnMouseDrag(){
		mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector2(mousePos.x - deltaX , transform.position.y);
	}
}

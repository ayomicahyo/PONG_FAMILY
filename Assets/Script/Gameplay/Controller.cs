using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	private float deltaX,deltaY;
	//Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	private void Update(){
		
		if(Input.touchCount > 0){
			Touch touch1 = Input.GetTouch(0);
			Vector2 touchPos1 = Camera.main.ScreenToWorldPoint(touch1.position);
			
			switch(touch1.phase){
				case TouchPhase.Began:
					if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1)){
						deltaX = touchPos1.x - transform.position.x;
						deltaY = touchPos1.y - transform.position.y;
					}
					break;
				
				case TouchPhase.Moved:
					if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1)){
						transform.position = new Vector2(touchPos1.x - deltaX , transform.position.y);
					}
					break;
			}
			
			Touch touch2 = Input.GetTouch(1);
			Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);
			
			switch(touch2.phase){
				case TouchPhase.Began:
					if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1)){
						deltaX = touchPos2.x - transform.position.x;
						deltaY = touchPos2.y - transform.position.y;
					}
					break;
				
				case TouchPhase.Moved:
					if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos1)){
						transform.position = new Vector2(touchPos2.x - deltaX , transform.position.y);
					}
					break;
			}
		}
	}
	
	/*void OnMouseDown(){
		deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
		deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
	}
	
	void OnMouseDrag(){
		mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector2(mousePos.x - deltaX , transform.position.y);
	}*/
}

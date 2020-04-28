using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeName : MonoBehaviour
{
	private Text thisText;
	public DB thisDB;
    // Start is called before the first frame update
    void Start()
    {
		thisText = GetComponent<Text>();
        thisText.text = thisDB.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

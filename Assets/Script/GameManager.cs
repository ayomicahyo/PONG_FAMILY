using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DB dataBase;
	
	public string nama;
	
	void Awake(){
		nama = dataBase.name;
	}
}

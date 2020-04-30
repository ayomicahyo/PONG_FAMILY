using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
	public string namaScene;
    // Start is called before the first frame update
    public void ChangeScenebyName(){
		StartCoroutine(Wait(2f));
	}
	
	
	IEnumerator Wait(float time){
		yield return new WaitForSeconds(time);
		SceneManager.LoadScene(namaScene);
	}
}

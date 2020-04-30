using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charanimationcontroll : MonoBehaviour
{
	public Animator charAnimator;
    // Start is called before the first frame update
    void Start()
    {
        charAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void ASkill(){
		charAnimator.SetBool("skill",true);
		StartCoroutine(Waiting(1f));
	}
	
	IEnumerator Waiting(float time)
    {
        
        yield return new WaitForSeconds(time);;
		charAnimator.SetBool("skill",false);
    }
}

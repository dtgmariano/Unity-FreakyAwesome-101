using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamusScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)){
			MoveLeft();
		}else if(Input.GetKey(KeyCode.RightArrow)){
			MoveRight();
		}
	}

	void MoveLeft()
	{
		Debug.Log ("MoveLeft()");
		//this.transformation.position =  Vector3.MoveTowards(pos3, too3, step3);
	}

	void MoveRight()
	{
		Debug.Log ("MoveRight()");
	}
}

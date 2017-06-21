using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishyScript : MonoBehaviour {

	bool isGrabbed = false;
	Vector3 startPosition;
	public float stretchiness = 10f;
	
	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)){
			ResetPosition();
		}
	}
	private void ResetPosition(){
		this.transform.position = startPosition;
		GetComponent<Rigidbody2D>().velocity = Vector3.zero;
		GetComponent<Rigidbody2D>().angularVelocity = 0f;
		GetComponent<Rigidbody2D>().gravityScale = 0f;
	}
	
	void FixedUpdate(){
		if(isGrabbed){
			Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			worldPosition.z = 0;
		this.transform.position = worldPosition;
		}
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
		if(coll.gameObject.name == "ganon_14") {
			GameObject.Destroy(coll.gameObject);
			print ("You Win!");
			ResetPosition();
		} else if(coll.gameObject.name == "MainIsland 2") {
			print ("KLONK!");
		}
	}
	
	void OnMouseDown(){
		Debug.Log ("FishScript.OnMouseDown()");
		isGrabbed = true;
		startPosition = this.transform.position;
	}
	
	void OnMouseUp(){
		isGrabbed = false;
		Vector3 delta = startPosition - this.transform.position;
		this.GetComponent<Rigidbody2D>().velocity = delta * stretchiness;
		this.GetComponent<Rigidbody2D>().gravityScale = 1f;
	}
}

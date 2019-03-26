using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Gets the current position of the mouse
		Vector3 mousePos2D = Input.mousePosition;

		// Sets how far to push the mouse into 3D
		mousePos2D.z = -Camera.main.transform.position.z;

		// Convert the point from 2D scren space into 3D game world space
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);

		// Move the basket based on the mouse
		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		this.transform.position = pos; // move the basket
		
	}

	void OnCollisionEnter(Collision coll){
		// something hit the basket what was it?
		GameObject collidedWith = coll.gameObject;
		// if it was an Apple destroy it
		if (collidedWith.tag == "Apple")
			Destroy (collidedWith);
	}
}

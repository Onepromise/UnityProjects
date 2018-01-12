using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody myBody;
	private float moveForce = 10f;

	void Awakw () {
		myBody = GetComponent<Rigidbody> ();
	}

	void Update () {
		float h = Input.GetAxis ("Horizontal");
		myBody.velocity = new Vector3 (-h * moveForce, 0f, 0f);
		
	}
}

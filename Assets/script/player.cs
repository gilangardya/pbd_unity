using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	private bool onGround;
	private float jumpPressure;
	private float minJump;
	private float maxJumpPressure;
	private Rigidbody rbody;

	// Use this for initialization
	void Start () {
		onGround = true;
		jumpPressure = 0;
		minJump = 5f;
		maxJumpPressure = 15f;
		rbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (onGround) {

			//holding jump button
			if (Input.GetButton ("Jump")) {
				if (jumpPressure < maxJumpPressure) {
					jumpPressure += Time.deltaTime * 10f;
				} else {
					jumpPressure = maxJumpPressure;
				}
			
			}

			//not holding jump button
			else {
				if (jumpPressure > 0f) {
					if (jumpPressure < minJump) {
						jumpPressure = minJump;
					}
					rbody.velocity = new Vector3 (0f, jumpPressure, 0f);
					onGround = false;
					jumpPressure = 0;
				}
			}
		}
			
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag ("ground")) {
			onGround = true;
			print ("HAHAHA");
		}
	}
}

using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour {

	public float speed;
	void FixedUpdate () {
		float moveHor = Input.GetAxis ("Horizontal");
		float moveVer = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHor, 0, moveVer);
		rigidbody.AddForce (movement * speed *Time.deltaTime);
		//为了确保帧独立，与delatetime相乘
	}
}

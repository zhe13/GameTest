using UnityEngine;
using System.Collections;

public class Rolling : MonoBehaviour {
	
	//因为没有涉及到力，所以直接使用update
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
		//为了确保平滑和帧独立所以x上deltaTime
	}
}

using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour {

	public float speed;
    public GUIText scoreTxt;
    private float score;
    public GUIText win;

    void Start()
    {
        score = 0;
        updateScore();
        win.text = "";
    }

	void FixedUpdate () 
    {
		float moveHor = Input.GetAxis ("Horizontal");
		float moveVer = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHor, 0, moveVer);
		rigidbody.AddForce (movement * speed *Time.deltaTime);
		//为了确保帧独立，与delatetime相乘
	}


	void OnTriggerEnter(Collider other) 
    {
		//Destroy(other.gameObject);
        if (other.gameObject.tag == "Coins")
        {
            other.gameObject.SetActive(false);
            score++;
            updateScore();
            if (score > 5)
                win.text = "You Win!";
        }
	}

    void updateScore()
    {
        scoreTxt.text = "Score:" + score.ToString();
    }
}

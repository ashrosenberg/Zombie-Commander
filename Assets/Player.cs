using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
<<<<<<< HEAD
	bool ismoving = false;
	private Animator animator;
	//private int count;
	//public Text countText;
	//public Text winText;

	void Start(){
		animator = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody>();
		//count = 0;
		//SetCountText ();
		//winText.text = "";
=======
	public GameObject avatar;
	private Animator animator;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		animator = avatar.GetComponent<Animator> ();

>>>>>>> origin/master
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

<<<<<<< HEAD
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		animator.SetBool("isMoving", true);
		rb.AddForce (movement* speed);
		animator.SetBool("isMoving", false);
	}
=======
		Vector3 movement = new Vector3 (moveHorizontal * Time.deltaTime, 0.0f, moveVertical * Time.deltaTime);

		if (movement != Vector3.zero) {
			animator.SetBool ("isMoving", true);
		} else {
			animator.SetBool("isMoving", false);
		}

		transform.Translate (movement);


>>>>>>> origin/master

	}

}

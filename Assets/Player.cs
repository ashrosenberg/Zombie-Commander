using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
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
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		animator.SetBool("isMoving", true);
		rb.AddForce (movement* speed);
		animator.SetBool("isMoving", false);
	}

	//void OnTriggerEnter(Collider other){
		//if (other.gameObject.CompareTag ("Pickup")) {
			//other.gameObject.SetActive (false);
			//count = count + 1;
			//SetCountText ();
		//}
	//}

	void SetCountText(){
		//countText.text = "Count: " + count.ToString ();
		//if (count >= 14) {
		//	winText.text = "You won!!";
		//}
	}

}

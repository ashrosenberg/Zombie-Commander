using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public GameObject avatar;
	private Animator animator;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		animator = avatar.GetComponent<Animator> ();

	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal * Time.deltaTime, 0.0f, moveVertical * Time.deltaTime);

		if (movement != Vector3.zero) {
			animator.SetBool ("isMoving", true);
		} else {
			animator.SetBool("isMoving", false);
		}

		transform.Translate (movement);



	}

}

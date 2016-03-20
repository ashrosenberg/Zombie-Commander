using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody rb;
	public float speed;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal * Time.deltaTime, 0.0f, moveVertical * Time.deltaTime);

		transform.Translate (movement);

	}

}

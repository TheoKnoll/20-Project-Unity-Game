using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	void FixedUpdate()
	{
		float moveHor = Input.GetAxis ("Horizontal");
		float moveVert = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHor, 0.0f, moveVert);

		rb.AddForce (movement * speed);
	}
}

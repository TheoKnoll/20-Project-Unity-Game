using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	private bool grounded;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		grounded = true;
	}

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("Ground")){
			
				grounded = true;
			}

			}



	void FixedUpdate()
	{
		float moveHor = Input.GetAxis ("Horizontal");
		float moveVert = Input.GetAxis ("Vertical");
		if(rb.transform)
		{

		}
		if(Input.GetKeyDown("space") && grounded == true){
			Vector3 movement = new Vector3 (moveHor, 20.0f, moveVert);
			rb.AddForce (movement * speed);
			grounded = false;
		}
		else
		{
		Vector3 movement = new Vector3 (moveHor, 0.0f, moveVert);
		rb.AddForce (movement * speed);
		}
			}

	void OnCollisionExit(Collision other){
		if(other.gameObject.CompareTag("Ground")){
				grounded = false;
			}

					}

	}

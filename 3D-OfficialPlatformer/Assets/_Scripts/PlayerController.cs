using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	public float jumpHeight;
	private bool grounded;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		grounded = true;
	}



	void Update(){
		if(Input.GetKeyDown(KeyCode.Space) && grounded ==true){
			Vector3 jump = new Vector3 (0.0f, jumpHeight, 0.0f);
			rb.AddForce(jump);
		}
	}

	void FixedUpdate()
	{
		float moveHor = Input.GetAxis ("Horizontal");
		float moveVert = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHor, 0.0f, moveVert);
		rb.AddForce (movement * speed);

			}


	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("Ground")){

			grounded = true;
		}
		else if(other.gameObject.CompareTag("RespawnGame")){
			Application.LoadLevel (Application.loadedLevel);
		}

	}

	void OnCollisionExit(Collision other){
		if(other.gameObject.CompareTag("Ground")){
				grounded = false;
			}

					}
	/*void OnColliderEnter(Collider other){
		if(other.gameObject.CompareTag("RespawnGame")){
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);
		}
	}*/

	}

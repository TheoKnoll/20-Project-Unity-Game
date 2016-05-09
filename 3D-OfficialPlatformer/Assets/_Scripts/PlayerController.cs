using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	public float jumpHeight;
	private bool grounded;
	private bool secondJumpAble;
	private bool secondJump;
	private float speedlimit;
	private float speedmax;
	private Renderer ren;
	private float sideSpeed;
	private bool isPaused;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		ren = GetComponent<Renderer> ();
		grounded = true;
		speedlimit = 10f;
		speedmax = 15;
		sideSpeed = 1;
		isPaused = false;
		secondJump = false;
		secondJumpAble = false;
	}



	void Update(){
		if(Input.GetKeyDown(KeyCode.Space) && (grounded == true)){
			Vector3 jump = new Vector3 (0.0f, jumpHeight, 0.0f);
			rb.AddForce(jump);
		}
		else if(Input.GetKeyDown(KeyCode.Space) && (secondJumpAble == true)){
			if(secondJump == true){
				Vector3 jump = new Vector3 (0.0f, jumpHeight, 0.0f);
				rb.AddForce(jump);
				secondJump = false;
			}

		}
		else if(Input.GetKeyDown(KeyCode.P)){
			Pause ();
		}
		else if(Input.GetKeyDown(KeyCode.M)||Input.GetKeyDown(KeyCode.Q)|| Input.GetKeyDown(KeyCode.Escape)){
			LoadMenu ();
		}
	}

	void FixedUpdate()
	{
		float moveHor = Input.GetAxis ("Horizontal");
		//float moveVert = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHor*sideSpeed, 0.0f, 0.0f);
		rb.AddForce (movement * speed);
		if(rb.velocity.z < speedmax){
			rb.AddForce (new Vector3 (0.0f, 0.0f, speedlimit));
		}
			}


	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("Ground")){

			grounded = true;
			if(secondJumpAble == true){
				secondJump = true;
			}
		}
		else if(other.gameObject.CompareTag("RespawnGame")){
		//	Application.LoadLevel (Application.loadedLevel);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		else if(other.gameObject.CompareTag("RespawnEnemy")){
			rb.AddForce (new Vector3 (0.0f, 0.0f, 15f));
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

	}

	void OnCollisionExit(Collision other){
		if(other.gameObject.CompareTag("Ground")){
			
				grounded = false;
			}

		}

	void OnCollisionStay(Collision other){
		if(other.gameObject.CompareTag("Ground")){

			grounded = true;
			if(secondJumpAble == true){
				secondJump = true;
			}

		}
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("SpeedPowerUp")){
			ren.material.color = Color.magenta;
			speedmax *= 2;
			speedlimit *= 2;
			sideSpeed *= 2;
			other.gameObject.SetActive(false);

		}
		else if(other.gameObject.CompareTag("JumpPowerUp")){
					ren.material.color = Color.green;
					jumpHeight *= 1.2f;
					secondJumpAble = true;
					other.gameObject.SetActive(false);

				}


	}

	void Pause(){
		if(isPaused == true){
			print ("Unpaused");
			Time.timeScale = 1.0f;
			isPaused = false;
		}
		else{
			print("Paused");
			Time.timeScale = 0.0f;
			isPaused = true;
		}

	}
	void LoadMenu(){
		SceneManager.LoadScene(1);
	}

}
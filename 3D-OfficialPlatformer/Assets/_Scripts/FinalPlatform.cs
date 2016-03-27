using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinalPlatform : MonoBehaviour {
	private int level = 0;

	void Start(){
		

	}
	void Update(){
		if(Input.GetKeyDown("n")){
			level = level + 1;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		}
	}
	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("Player")){
			level = level + 1;
			//Application.LoadLevel ("Level"+level);
			//SceneManager.LoadScene(2);
		}
	}
}

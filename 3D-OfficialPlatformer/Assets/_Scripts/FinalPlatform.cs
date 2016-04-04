using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinalPlatform : MonoBehaviour {
	

	void Start(){
		

	}
	void Update(){
		if(Input.GetKeyDown("n")){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		}
		else if(Input.GetKeyDown("r")){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("Player")){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		}
	}
}

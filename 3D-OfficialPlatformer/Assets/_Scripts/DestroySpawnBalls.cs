using UnityEngine;
using System.Collections;

public class DestroySpawnBalls : MonoBehaviour {


	void OnCollisionEnter(Collision other) {
		if(other.gameObject.CompareTag("Respawn")){
		GameObject.Destroy (gameObject);
		}
	}

}

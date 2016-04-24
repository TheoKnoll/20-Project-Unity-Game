using UnityEngine;
using System.Collections;

public class BallSpawn : MonoBehaviour {

	public Vector3 spawnValues;
	public GameObject hazard;
	private  int startWait;

	// Use this for initialization
	void Start () {
			startWait = 1;
		StartCoroutine(SpawnHazards ());

	}

	IEnumerator SpawnHazards(){
		yield return new WaitForSeconds (startWait);
		while(true){
			

			Vector3 spawnPo = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, Random.Range(spawnValues.z, spawnValues.z-5));
			Quaternion spawnRot = Quaternion.identity;
			//Instantiate (hazard, spawnPo, spawnRot);
			//
			GameObject go = Instantiate(hazard, spawnPo, spawnRot) as GameObject;
			go.GetComponent <MeshRenderer> ().material.color = new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
			//StartCoroutine (DeleteHazards (go));

			yield return new WaitForSeconds (.3f);
		}
}
	/*IEnumerator DeleteHazards(GameObject x){
		yield return new WaitForSeconds (2.7f);
		while(true){
			GameObject.Destroy (x);
			yield return new WaitForSeconds (2.7f);
		}
	}*/
}

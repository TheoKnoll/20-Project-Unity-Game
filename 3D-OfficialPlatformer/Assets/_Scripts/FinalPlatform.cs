using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinalPlatform : MonoBehaviour {
	private static int[] levelsBeat = new int[16];
	private static bool done = false;

	void Awake(){
		if((SceneManager.GetActiveScene ().buildIndex == 1 || SceneManager.GetActiveScene ().buildIndex == 2 ) && done == false){
			for(int x= 0; x < levelsBeat.Length; x++){
				levelsBeat [x] = -1;
			}
			done = true;
		}
	}
	void Update(){
		if(Input.GetKeyDown("n")){
			if (SceneManager.GetActiveScene ().buildIndex != levelsBeat.Length) {
				LevelBeat (SceneManager.GetActiveScene ().buildIndex);
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			} else {
				LevelBeat (SceneManager.GetActiveScene ().buildIndex);
				CheckWin();
			}
		}
		else if(Input.GetKeyDown("r")){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("Player")){
			LevelBeat (SceneManager.GetActiveScene ().buildIndex);
			if (SceneManager.GetActiveScene ().buildIndex != levelsBeat.Length) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			} else {
				LevelBeat (SceneManager.GetActiveScene ().buildIndex);
				CheckWin ();

			}
		}
	}
	void LevelBeat(int x){
		if(CheckBeat(x) == false){
		for(int y = 0; y < levelsBeat.Length; y++){
			if(levelsBeat[y] == -1){levelsBeat[y] = (x-1);
				break;}
		}
		}
	}

	void CheckWin(){
		if(containsAll() == true){
			SceneManager.LoadScene (levelsBeat.Length+1);
		}
		else{
			SceneManager.LoadScene (1);
		}

	}

	public bool CheckBeat(int x){
		for(int y = 0; y<levelsBeat.Length; y++){
			if(x == levelsBeat[y]){
				return true;
			}
		}
		return false;
	}

	bool containsAll(){
		for(int x = 1; x < levelsBeat.Length; x++){
			if (CheckBeat(x) == false) {
				return false;
			}
		}
		return true;
	}
}

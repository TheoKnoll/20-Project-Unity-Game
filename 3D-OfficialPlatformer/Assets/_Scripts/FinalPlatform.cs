using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinalPlatform : MonoBehaviour {
	private static bool beat1 = false, beat2 = false, beat3 = false, beat4 = false, beat5 = false, beat6 = false, beat7 = false, beat8 = false, beat9 = false, beat10 = false, beat11 = false, beat12 = false, beat13 = false;

	void Start(){
		

	}
	void Update(){
		if(Input.GetKeyDown("n")){
			if (SceneManager.GetActiveScene ().buildIndex != 14) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			} else {
				CheckWin();
			}
		}
		else if(Input.GetKeyDown("r")){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("Player")){
			if (SceneManager.GetActiveScene ().buildIndex != 14) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			} else {
				CheckWin ();

			}
			LevelBeat (SceneManager.GetActiveScene ().buildIndex);
		}
	}
	void LevelBeat(int x){
		if(x == 2){beat1 = true;}
		else if(x == 3){beat2 = true;}
		else if(x == 4){beat3 = true;}
		else if(x == 5){beat4 = true;}
		else if(x == 6){beat5 = true;}
		else if(x == 7){beat6 = true;}
		else if(x == 8){beat7 = true;}
		else if(x == 9){beat8 = true;}
		else if(x == 10){beat9 = true;}
		else if(x == 11){beat10 = true;}
		else if(x == 12){beat11 = true;}
		else if(x == 13){beat12 = true;}
		else if(x == 14){beat13 = true;}
	}

	void CheckWin(){
		if (beat1 == true && beat2 == true && beat3 == true && beat4 == true && beat5 == true && beat6 == true && beat7 == true && beat8 == true && beat9 == true && beat10 == true && beat11 == true && beat12 == true && beat13) {
			SceneManager.LoadScene (15);
		} else {
			SceneManager.LoadScene (1);
		}
	}
}

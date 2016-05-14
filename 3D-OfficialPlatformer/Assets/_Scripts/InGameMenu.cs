using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour {
	public Canvas quitMenuu;
	public Button startB;
	public Button quitB;
	public Canvas levelMenu;
	public Canvas BasicMenu;
	// Use this for initialization
	void Start () {
		BasicMenu.enabled = true;
		quitMenuu = quitMenuu.GetComponent<Canvas> ();
		startB = startB.GetComponent<Button> ();
		quitB = quitB.GetComponent<Button> ();
		quitMenuu.enabled = false;
		levelMenu.enabled = false;
	}

	public void ExitPress(){
		quitMenuu.enabled = true;
		startB.enabled = false;
		quitB.enabled = false;
		levelMenu.enabled = false;
	}

	public void NoPress(){
		quitMenuu.enabled = false;
		startB.enabled = true;
		quitB.enabled = true;
		levelMenu.enabled= false;
		BasicMenu.enabled = true;
	}

	public void StartLevel(){
		levelMenu.enabled = true;
		quitMenuu.enabled = false;
		startB.enabled = false;
		quitB.enabled = false;
		BasicMenu.enabled = false;

	}

	public void ExitGame(){
		Application.Quit ();
	}

	public void Load1(){
		
			SceneManager.LoadScene(2);

			}

	public void Load2(){
		
			SceneManager.LoadScene(3);

	}

	public void Load3(){
		
			SceneManager.LoadScene(4);

	}

	public void Load4(){
		
			SceneManager.LoadScene(5);

	}

	public void Load5(){
		
			SceneManager.LoadScene(6);

	}

	public void Load6(){
		
			SceneManager.LoadScene(7);

	}

	public void Load7(){
		
			SceneManager.LoadScene(8);

	}

	public void Load8(){
		
			SceneManager.LoadScene(9);

	}

	public void Load9(){
		
			SceneManager.LoadScene(10);

	}

	public void Load10(){
		
			SceneManager.LoadScene(11);

	}

	public void Load11(){

		SceneManager.LoadScene(12);

	}

	public void Load12(){

		SceneManager.LoadScene(13);

	}

	public void Load13(){

		SceneManager.LoadScene(14);

	}

	public void Load14(){

		SceneManager.LoadScene(15);

	}

	public void Load15(){

		SceneManager.LoadScene(16);

	}

	public void Load16(){

		SceneManager.LoadScene(17);

	}


	public void Load17(){

		SceneManager.LoadScene(18);

	}

	public void Load18(){

		SceneManager.LoadScene(19);

	}

	public void Load19(){

		SceneManager.LoadScene(20);

	}

	public void Load20(){

		SceneManager.LoadScene(21);

	}

	public void Load21(){

		SceneManager.LoadScene(22);

	}
}

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
		
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

			}

	public void Load2(){
		
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);

	}

	public void Load3(){
		
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);

	}

	public void Load4(){
		
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+4);

	}

	public void Load5(){
		
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+5);

	}

	public void Load6(){
		
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+6);

	}

	public void Load7(){
		
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+7);

	}

	public void Load8(){
		
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+8);

	}

	public void Load9(){
		
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+9);

	}

	public void Load10(){
		
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+10);

	}

	public void Load11(){

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+11);

	}

	public void Load12(){

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+12);

	}

	public void Load13(){

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+13);

	}
}

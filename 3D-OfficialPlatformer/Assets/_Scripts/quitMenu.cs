using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class quitMenu : MonoBehaviour {
	public Canvas quitMenuu;
	public Button startB;
	public Button quitB;
	// Use this for initialization
	void Start () {
		quitMenuu = quitMenuu.GetComponent<Canvas> ();
		startB = startB.GetComponent<Button> ();
		quitB = quitB.GetComponent<Button> ();
		quitMenuu.enabled = false;
	}

	public void ExitPress(){
		quitMenuu.enabled = true;
		startB.enabled = false;
		quitB.enabled = false;
	}

	public void NoPress(){
		quitMenuu.enabled = false;
		startB.enabled = true;
		quitB.enabled = true;
	}

	public void StartLevel(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
	}

	public void ExitGame(){
		Application.Quit ();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
		
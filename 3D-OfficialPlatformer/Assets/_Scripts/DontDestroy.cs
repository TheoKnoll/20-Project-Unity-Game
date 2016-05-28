using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DontDestroy : MonoBehaviour {
	public Canvas qm;
	public Button toggle;
	private bool playing;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
	}
	void Start(){
		qm = qm.GetComponent<Canvas> ();
		toggle = toggle.GetComponent<Button> ();
	
		//playing = true;
		//AudioListener.pause = false;
	}
	// Update is called once per frame
	public void musicToggle() {
		if (playing) {
			AudioListener.pause = true;
			playing = false;

		} else {
			
			playing = true;
			AudioListener.pause = false;
		}
	}

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour {
	public Transform button;
	public int level;
	public FinalPlatform fp;
	// Use this for initialization
	void Start () {

	}
	
	void Update () {


		if (fp.CheckBeat(level-1) == false)
		{
			button.GetComponent<Button>().interactable = false; 
			}
			else 
			{
				button.GetComponent<Button>().interactable = true;
			}

		}
}

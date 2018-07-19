using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameControl : MonoBehaviour {

	public Scrollbar scroll;
	int sceneIndex;

	void Start(){
		sceneIndex = SceneManager.GetActiveScene ().buildIndex;
		Debug.Log ("you're in:" + SceneManager.GetActiveScene ().name);
		Debug.Log ("index:" + sceneIndex);
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (sceneIndex == 0)
				Application.Quit ();
			else if (sceneIndex == 3) {
				Debug.Log ("Do Nothing.");
			}
			else
				SceneManager.LoadScene (sceneIndex - 1);
		}
	}


	public void ketujuan(string tujuan) {
		SceneManager.LoadScene(tujuan);
	}

	public void scrollAddClick(float addValue){
		scroll.value = scroll.value + addValue;
	}
	public void scrollMinClick(float addValue){
		scroll.value = scroll.value - addValue;
	}
}

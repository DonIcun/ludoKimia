using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class btseting : MonoBehaviour {


	public void ketujuan(string tujuan) {
		SceneManager.LoadScene(tujuan);
	}

	public void keluarGame(){
		Application.Quit ();
	}


}

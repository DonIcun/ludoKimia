using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGSoundScript : MonoBehaviour {
	public bool statusplay=true;

	// Use this for initialization
	void Start () {
		
	}

    //Play Global
    private static BGSoundScript instance = null;
    public static BGSoundScript Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    //Play Gobal End

    // Update is called once per frame
    void Update () {
		if(SceneManager.GetActiveScene().name == "bermain"){
			Debug.Log ("masuk game");
			Destroy (this.gameObject);
		}
	}

	public void pausesong(){
		BGSoundScript.instance.gameObject.GetComponent<AudioSource> ().Pause ();
		statusplay = false;
	}
	public void playsong(){
		BGSoundScript.instance.gameObject.GetComponent<AudioSource> ().Play ();
		statusplay = true;
	}

	public void playsongcontroller(){
		if (statusplay == true) {
			pausesong ();
		} else {
			playsong ();
		}
	}
}

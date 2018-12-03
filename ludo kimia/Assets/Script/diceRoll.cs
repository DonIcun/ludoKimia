using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diceRoll : MonoBehaviour {
	int langkah;
	public Sprite[] dice;
	private Image dadu;
	public static bool isEnd = false;
	private int player;
	// Use this for initialization
	void Start () {
		dadu = GetComponent<Image> ();
		dice = Resources.LoadAll<Sprite>("DiceSides/");
		//dadu.sprite = dice [1];
		langkah = 0;
		player = 0;
	}

	public void Randomdice(){
		StartCoroutine ("RollTheDice");
	}
	private IEnumerator RollTheDice(){
		int randomDadu = 0;
		int nilaiDadu = 0;
		for (int i = 0; i <= 10; i++) {
			//diberi nilai 8 untuk meningkatkan kesempatan nilai 6
			randomDadu = Random.Range (0, 8);
			//membuat maksimal nilai 6
			if (randomDadu>=5){
				nilaiDadu = 5;
				dadu.sprite = dice [nilaiDadu];
			}
			else{
				nilaiDadu = randomDadu;
				dadu.sprite = dice [nilaiDadu];
			}
			yield return new WaitForSeconds (0.05f);
		}
		//percobaan
		if (nilaiDadu >= 5) {
			isEnd = true;
			player += 1;
		}


		if (isEnd == true) {
			memilihPlayer.indexPemain = player % 4;
		}
		langkah += 1;
		int nilailog = nilaiDadu + 1;
		Debug.Log ("Langkah: " + langkah + "dadu: "+ nilailog );
		isEnd = false;
	}


}

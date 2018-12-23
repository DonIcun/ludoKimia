using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diceRoll : MonoBehaviour {
	int nilaiAhir;
	public Sprite[] dice;
	private Image dadu;
	//public static bool isEnd = false;
	public static bool diceAllowed = true;
	public static int player;
	public static int langkah;

	void Start () {
		dadu = GetComponent<Image> ();
		dice = Resources.LoadAll<Sprite>("DiceSides/");
//		//dadu.sprite = dice [1];
		langkah = 1;
//		player = 0;
		cekplayer ();
	}

	public void Randomdice(){
		cekplayer ();
		if (diceAllowed) {
			StartCoroutine ("RollTheDice");
			diceAllowed = false;
		}

	}

	private IEnumerator RollTheDice(){
		int randomDadu = 0;
		int nilaiDadu = 0;


		for (int i = 0; i <= 10; i++) {
			//diberi nilai 8 untuk meningkatkan kesempatan nilai 6
			randomDadu = Random.Range (0, 6);
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
		nilaiAhir = nilaiDadu + 1;
		playerControl.hasilDadu = nilaiAhir;
		Debug.Log ("hasil dadu turn:"+langkah+" = " + playerControl.hasilDadu);
		//percobaan
		hitunglangkah();
		cekPlayercanmove (player);
		//isEnd = false;

	}

	public void cekplayer(){
		if (playerControl.jumPlayer == 2) {
			switch (langkah % playerControl.jumPlayer) {
			case 0:
				player = 2;
				break;
			case 1:
				player = 4;
				break;
			}
		} else {
			player = langkah % playerControl.jumPlayer;
			if (player == 0) {
				player = playerControl.jumPlayer;
			}
		}
	}

	public void hitunglangkah(){
		if (nilaiAhir == 6) {
		}else{
			cekplayer ();
			langkah += 1;
		}
		Debug.Log ("Langkah ke: " + langkah +"_player: " + player + "_dadu: " + nilaiAhir);
	}

	public void cekPlayercanmove(int playercek){
		int numbPlayCanmove = 0;
		if (playerControl.hasilDadu == 6) {
			Debug.Log ("this player can move");
		}else{
			for (int i = 0; i < 4; i++) {
				if (playerControl.players [playercek, i] == 0) {
					Debug.Log ("pion" + i +"player"+player+ "can't move");
				} else {
					numbPlayCanmove =+ 1;
				}
			}
			if (numbPlayCanmove == 0) {
				diceRoll.diceAllowed = true;
			}
		}
	}

}

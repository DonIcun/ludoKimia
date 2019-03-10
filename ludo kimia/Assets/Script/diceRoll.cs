using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diceRoll : MonoBehaviour {
	int nilaiAhir;
	public string statusturn;
	public Sprite[] dice;
	private Image dadu;
	public Text textinfo,textplayturn;
	//public static bool isEnd = false;
	public static bool diceAllowed = true;
	public static int player;
	public static int langkah;
	public static int nilaiDadu;
	public AudioClip sounddice;
	public AudioSource sources;

	void Start () {
		dadu = GetComponent<Image> ();
		dice = Resources.LoadAll<Sprite>("DiceSides/");
//		//dadu.sprite = dice [1];
		langkah = 1;
		player = 0;
		cekplayer ();
		//sources.PlayOneShot (sounddice);
	}

	public void Randomdice(){
		if (diceAllowed) {
			cekplayer ();
			playsound ();
			StartCoroutine ("RollTheDice");
			diceAllowed = false;
		} else {
			StartCoroutine ("GagalRoll");

		}

	}

	private IEnumerator RollTheDice(){
		int randomDadu = 0;
		nilaiDadu = 0;
		for (int i = 0; i <= 15; i++) {
			//diberi nilai 7 untuk meningkatkan kesempatan nilai 6
			randomDadu = Random.Range (0, 7);
			//membuat maksimal nilai 6
			if (randomDadu>=5){
				nilaiDadu = 5;
				dadu.sprite = dice [nilaiDadu];
			}
			else{
				nilaiDadu = randomDadu;
				//nilaiDadu = 5;
				dadu.sprite = dice [nilaiDadu];
			}
			yield return new WaitForSeconds (0.05f);
		}
		nilaiAhir = nilaiDadu + 1;
		playerControl.hasilDadu = nilaiAhir;
		playerControl.tempDadu = playerControl.hasilDadu;
		Debug.Log ("hasil dadu turn:"+langkah+" = " + playerControl.hasilDadu);
		//percobaan
		hitunglangkah();
		cekPlayercanmove (player);
		//isEnd = false;

	}

	private IEnumerator GagalRoll(){
		textinfo.text = "pemain "+player+" belum jalan";
		for (int i = 0; i <= 4; i++) {
			yield return new WaitForSeconds (0.15f);
			if (i == 4) {
				textinfo.text = "";
			}
		}
			
	}

	public void cekplayer(){
		if (PlayerPrefs.GetInt("jumplayin") == 2) {
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
		playerturn (player);
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
					Debug.Log ("pion" + i + "player" + player + "can't move");
				} else if (playerControl.players [playercek, i] >= 57) {
					Debug.Log ("pion" + i + "player" + player + "can't move");
				}  
				else {
					numbPlayCanmove =+ 1;
				}
			}
			if (numbPlayCanmove == 0) {
				diceRoll.diceAllowed = true;
			}
		}
	}

	public void playsound(){
			sources.PlayOneShot (sounddice);
			Debug.Log ("sound played");
	}

	public void playerturn(int player){
		switch (player) {
		case 1:
			statusturn = "main : hijau";
			break;
		case 2:
			statusturn = "main : kuning";
			break;
		case 3:
			statusturn = "main : biru";
			break;
		case 4:
			statusturn = "main : merah";
			break;
		}
		textplayturn.text = statusturn;
	}

}
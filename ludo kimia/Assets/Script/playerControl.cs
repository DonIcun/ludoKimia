using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerControl : MonoBehaviour {
	public static int jumPlayer;
	public static int hasilDadu = 0;
	public static int playerPos;
	public GameObject[] pinPlayer;
	public static int[,] players;
	public static int[,] playerInMap;
	public GameObject canvasPilih,canvasMain;

	void Awake(){
		jumPlayer = 2;
	}
	// Use this for initialization
	void Start () {
//		DontDestroyOnLoad (this);
		jumlahPlayer (jumPlayer);
		canvasPilih.SetActive (true);
		canvasMain.SetActive (false);

		players = new int[,]{
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
		};
		playerInMap = new int[,] {
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 13, 13, 13, 13 },
			{ 26, 26, 26, 26 },
			{ 39, 39, 39, 39 },
				
		};
	}

	public void jumlahPlayer(int jumlah){
		jumPlayer = jumlah;
		if (jumlah == 2) {
			pinPlayer [3].SetActive (true);
			pinPlayer [1].SetActive (true);
			pinPlayer [0].SetActive (false);
			pinPlayer [2].SetActive (false);
		} else {
			for (int i = 0; i < 4; i++) {
				if (i < jumlah) {
					pinPlayer [i].SetActive (true);
				} else {
					pinPlayer [i].SetActive (false);
				}
			}
		}
	}

	public void PosPlayer(string hasil){
		string[] splitParams= hasil.Split(',');
		string param1 = splitParams [0];
		string param2 = splitParams [1];
		int isPlayer = int.Parse (param1);
		int pionPlayer = int.Parse (param2);			
		if (players [isPlayer, pionPlayer] == 0) {
			if (hasilDadu == 6) {
				players [isPlayer, pionPlayer] = players [isPlayer, pionPlayer] + hasilDadu;
				MovePlayerTo (isPlayer, pionPlayer);
				Debug.Log ("turn"+ diceRoll.langkah +" player move to"+players [isPlayer, pionPlayer]);
			} else {
				Debug.Log ("player" + isPlayer + "pion ke " + pionPlayer + "tidak bisa jalan");
				diceRoll.diceAllowed = true;
			}
		} else {
			players [isPlayer, pionPlayer] = players [isPlayer, pionPlayer] + hasilDadu;
			MovePlayerTo (isPlayer, pionPlayer);
			Debug.Log ("turn"+ diceRoll.langkah +" player move to"+players [isPlayer, pionPlayer]);
		}
	}

	public static void MovePlayerTo(int playermove,int pion){
		int isPlayer = playermove;
		int pionPlayer = pion;			
		if (isPlayer == diceRoll.player) {
			playerPos = players [isPlayer, pionPlayer];
			hasilDadu = 0;
			playerOnMap (isPlayer, pionPlayer);
		} else {
			Debug.Log ("Bukan playernya, sekarang player " + diceRoll.player);
		}
	}

	public static void playerOnMap(int plmove,int plpion){
		int playermove = plmove;
		int pion = plpion;
		switch (playermove) {
		case 1:
			if (players [playermove, pion] < 51) {
				playerInMap [playermove, pion] = players [playermove, pion];
			} else {
				playerInMap [playermove, pion] = players [playermove, pion]+100;
			}
			break;
		
		case 2:
			if (players [playermove, pion] < 51) {
				playerInMap [playermove, pion] = (players [playermove, pion] + 13) % 52;
			} else {
				playerInMap [playermove, pion] = players [playermove, pion] + 200;
			}				
			break;
		
		case 3:
			if (players [playermove, pion] < 51) {
				playerInMap [playermove, pion] = (players [playermove, pion] + 26) % 52;
			} else {
				playerInMap [playermove, pion] = players [playermove, pion] + 300;
			}				
			break;			

		case 4:
			if (players [playermove, pion] < 51) {
				playerInMap [playermove, pion] = (players [playermove, pion] + 39) % 52;
			} else {
				playerInMap [playermove, pion] = players [playermove, pion] + 400;
			}				
			break;

		}
	}

}

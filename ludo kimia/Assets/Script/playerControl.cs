using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerControl : MonoBehaviour {
	public static int jumPlayer;
	public static int hasilDadu = 0,tempDadu;
	public static int playerPos;
	public GameObject[] pinPlayer;
	public static int[,] players;
	public static int[,] playerInMap;
	public GameObject canvasPilih,canvasMain;
	public GameObject[] plbiru, plmerah, plkuning, plhijau;

	void Awake(){
		jumPlayer = 2;
	}
	// Use this for initialization
	void Start () {
//		DontDestroyOnLoad (this);
		jumlahPlayer (jumPlayer);
		canvasPilih.SetActive (true);
		//canvasMain.SetActive (false);

		players = new int[,]{
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
			{ 0, 0, 0, 0 },
		};
		playerInMap = new int[,] {
			{ 0, 0, 0, 0 },
			{ -1, -1, -1, -1 },
			{ -1, -1, -1, -1 },
			{ -1, -1, -1, -1 },
			{ -1, -1, -1, -1 },

		};
	}

	public void jumlahPlayer(int jumlah){
		jumPlayer = jumlah;
		PlayerPrefs.SetInt("jumplayin",jumPlayer);
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
			//	players [isPlayer, pionPlayer] = 1;
				MovePlayerTo (isPlayer, pionPlayer);
				Debug.Log ("turn"+ diceRoll.langkah +" player move to"+players [isPlayer, pionPlayer]);
			} else {
				Debug.Log ("player" + isPlayer + "pion ke " + pionPlayer + "tidak bisa jalan");
			}
		} else {
			MovePlayerTo (isPlayer, pionPlayer);
			Debug.Log ("turn"+ diceRoll.langkah +" player move to"+players [isPlayer, pionPlayer]);
		}
	}

	public static void MovePlayerTo(int playermove,int pion){
		int isPlayer = playermove;
		int pionPlayer = pion;			
		if (isPlayer == diceRoll.player) {
			if (players [isPlayer, pionPlayer] == 0) {
				players [isPlayer, pionPlayer] = 1;
			} else {
				if (players [isPlayer, pionPlayer] + hasilDadu > 57) {
					players [isPlayer, pionPlayer] = 57;
				} else {
					players [isPlayer, pionPlayer] = (players [isPlayer, pionPlayer] + hasilDadu);
					//tester saja
//					switch(isPlayer){
//					case 1:
//						players [isPlayer, pionPlayer] = 10;
//						break;
//					case 2:
//						players [isPlayer, pionPlayer] = 49;
//						break;
//					case 3:
//						players [isPlayer, pionPlayer] = 36;
//						break;
//					case 4:
//						players [isPlayer, pionPlayer] = 23;
//						break;
//					}
				}
			}
			//playerPos = players [isPlayer, pionPlayer];
			hasilDadu = 0;
			playerOnMap (isPlayer, pionPlayer);
			diceRoll.diceAllowed =true;
			winCondition.cekmenang (isPlayer);
		} else {
			//hasilDadu = 0;
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
				playerInMap [playermove, pion] = players [playermove, pion] + 100;
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
		Debug.Log ("posisi pl1: "+ playerInMap [1,0]+"-"+playerInMap [1,1]+"-"+playerInMap [1,2]+"-"+playerInMap [1,3]);
		Debug.Log ("posisi pl2: "+ playerInMap [2,0]+"-"+playerInMap [2,1]+"-"+playerInMap [2,2]+"-"+playerInMap [2,3]);
		Debug.Log ("posisi pl3: "+ playerInMap [3,0]+"-"+playerInMap [3,1]+"-"+playerInMap [3,2]+"-"+playerInMap [3,3]);
		Debug.Log ("posisi pl4: "+ playerInMap [4,0]+"-"+playerInMap [4,1]+"-"+playerInMap [4,2]+"-"+playerInMap [4,3]);

	}

	public void cekPosSama(int plmove,int plpion){
		int nilaicek = players [plmove, plpion];
		if (plmove == diceRoll.player) {
			switch (nilaicek) {
			case 3:
			case 5:
			case 7:
				bukaSoal (1);
				break;
			case 11:
			case 13:
			case 16:
			case 18:
			case 20:
			case 24:
			case 26:
			case 29:
			case 31:
			case 33:
			case 37:
			case 39:
			case 42:
				bukaSoal (2);
				break;
			case 44:
			case 46:
			case 50:
				bukaSoal (3);
				break;
			case 53:
			case 55:
				bukaSoal (4);
				break;

			}
		} else {
			Debug.Log ("player " + plmove + " tidak menerima soal");
		}	
		cekPosMap (plmove, plpion);
	}

	public void bukaSoal(int i){
		int numsoal;
		switch(i) {
		case 1:
			numsoal = Random.Range (0, 6);
			GameManager.Singleton.SetSoal (numsoal);
			break;
		case 2:
			numsoal = Random.Range (7,34);
			GameManager.Singleton.SetSoal (numsoal);
			break;
		case 3:
			numsoal = Random.Range (35,45);
			GameManager.Singleton.SetSoal (numsoal);
			break;
		case 4:
			numsoal = Random.Range (45,50);
			GameManager.Singleton.SetSoal (numsoal);
			break;	
		}

	}

	public void cekPosMap(int plmove,int plpion){
		int cekOnMap = playerInMap [plmove, plpion];
		if(cekOnMap <= 52){
			switch (cekOnMap) {
			case 9:
			case 22:
			case 35:
			case 48:
				cekPosStay ();
				break;
			default:
				cekPosKick (plmove,plpion);
				break;
			}
		}
	}

	public void cekPosKick(int plmove,int plpion){
		int thisplayer = playerInMap [plmove, plpion];
		for (int i = 1; i <= 4; i++) {
			if (i != plmove) {
				for(int j = 0;j<4;j++){
					if (thisplayer == playerInMap [i, j]) {
						Debug.Log ("player [" + plmove + "-" + plpion + "] pos same with [" + i + "-" + j + "] at = "+ thisplayer);
						switch (i) {
						case 1:
							plhijau [j].GetComponent<bermainControl> ().moveBackward ();
							players[i,j]=0;
							playerInMap[i,j]=-1;
							break;
						case 2:
							plkuning[j].GetComponent<bermainControl> ().moveBackward ();
							players[i,j]=0;
							playerInMap[i,j]=-1;
							break;
						case 3:
							plbiru[j].GetComponent<bermainControl> ().moveBackward ();
							players[i,j]=0;
							playerInMap[i,j]=-1;
							break;
						case 4:
							plmerah[j].GetComponent<bermainControl> ().moveBackward ();
							players[i,j]=0;
							playerInMap[i,j]=-1;
							break;
						}
					}
						
				}
			}
		}
	}
	public void cekPosStay(){
		int plmove = diceRoll.player - 1;
		pinPlayer[plmove].GetComponent<Canvas>().sortingOrder = 2 ;
		Debug.Log ("player "+plmove + "layer 2");
		for (int i = 0; i < 4; i++) {
			if (i != plmove) {
				pinPlayer[i].GetComponent<Canvas>().sortingOrder = 1 ;
				Debug.Log ("player "+i + "layer 1");
				}
			}
	}



}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class winCondition : MonoBehaviour {
	public static int[] playerFinis;
	public static GameObject canvasMenang,btLempar;
	public static GameObject[] playermenang;
	public static Sprite medali;
	public static Text textmenang;
	public static string[] whowin = new string[]{"null","Hijau","Kuning","Biru","Merah"}; 

	// Use this for initialization
	void Start () {
		playerFinis = new int[]{ 0,0,0,0,0};
		canvasMenang = GameObject.Find ("PanelMenang");
		playermenang = new GameObject[5];
		playermenang[1] = GameObject.Find ("playerhijau");
		playermenang[2] = GameObject.Find ("playerkuning");
		playermenang[3] = GameObject.Find ("playerbiru");
		playermenang[4] = GameObject.Find ("playermerah");
//		playermenang = new List<GameObject>();
//		playermenang.Insert (1,GameObject.Find ("playerhijau"));
//		playermenang.Insert (2,GameObject.Find ("playerkuning"));
//		playermenang.Insert (3,GameObject.Find ("playerbiru"));
//		playermenang.Insert (4,GameObject.Find ("playermerah"));
		textmenang = GameObject.Find("TextMenang").GetComponent<Text>();
		medali = Resources.Load<Sprite> ("crown");
		canvasMenang.SetActive (false);
//		textmenang.text = "selamat";

	}
	
	public static void wincondition(int playerwin){
		string textfinal;
		canvasMenang.SetActive (true);
		playermenang [playerwin].GetComponent<Image>().sprite	 = medali;
		btLempar.SetActive (false);
		textfinal = "player " + whowin[playerwin] + " menang";
		textmenang.text = textfinal;
	}

	public static void cekmenang(int playercek){
		playerFinis [playercek] = 0;	
		for (int j = 0; j < 4; j++) {
			if (playerControl.players [playercek, j] >= 56) {
				playerFinis [playercek] += 1;
			}
			if (playerFinis [playercek] == 4) {
				wincondition (playercek);
				}
			}
		Debug.Log ("pin " + whowin [playercek] + "finish sebanyak" + playerFinis [playercek]);
	}


	}
	
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerControl : MonoBehaviour {
	public int jumPlayer;
	public string[] player;
	public InputField[] nama;
	public Toggle[] rn;
	public Toggle pl2, pl3, pl4;

	// Use this for initialization
	void Start () {
		player = new string[4];
		jumPlayer = 2;
		pl2.isOn = true;
	}

	public void jumlahPlayer(int jumlah){
		jumPlayer = jumlah;
		for (int i = 0; i < 4; i++) {
			if (i < jumPlayer) {
				rn [i].isOn = true;
				nama [i].interactable = true;
			} else {
				rn [i].isOn = false;
				nama [i].interactable = false;
			}
		}
	}

	public void  namaPlayer(){
		for (int i = 0; i < jumPlayer; i++) {
			player[i] = nama[i].text;
		}

	}

	public void tampilNama(){
		for (int i = 0; i < jumPlayer; i++) {
			Debug.Log(player[i]);		
		}
	}



}

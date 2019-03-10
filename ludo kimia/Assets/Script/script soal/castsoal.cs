using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class castsoal : MonoBehaviour {
	int soalke,soalback,nomorSoalDitampilkan;
	public Image bta,btb,btc,btd;
	public Sprite btsalah, btbenar;
	public GameObject btkanan,btkiri;
	// Use this for initialization
	void Start () {
		nomorSoalDitampilkan = 0;
		//Soal[] kumpulansoal = GameManager.Singleton.paketSoal.kumpulanSoal;
	}

	void Update(){
		if (nomorSoalDitampilkan < 2) {
			btkiri.SetActive (false);
		} else if (nomorSoalDitampilkan > 48) {
			btkanan.SetActive (false);
		} else {
			btkanan.SetActive (true);
			btkiri.SetActive (true);
		}
	}

	public void nextSoal(int i){
		if (nomorSoalDitampilkan >= 50) {
			Debug.Log ("batas no.soal" + nomorSoalDitampilkan);
		} else if (nomorSoalDitampilkan < 50) {
			soalke = nomorSoalDitampilkan + i;
			nomorSoalDitampilkan = soalke;
			GameManager.Singleton.SetSoal (nomorSoalDitampilkan -1);
			tampiljawaban ();
		}
	}
	public void prevSoal(int i){
		if (nomorSoalDitampilkan < 0) {
			Debug.Log ("batas no.soal" + nomorSoalDitampilkan);
		} else if(nomorSoalDitampilkan > 0) {
			soalback = nomorSoalDitampilkan - i;
			nomorSoalDitampilkan = soalback;
			GameManager.Singleton.SetSoal (nomorSoalDitampilkan -1);
			tampiljawaban ();
		}
	}

	public void tampiljawaban(){
		Soal[] kumpulansoal = GameManager.Singleton.paketSoal.kumpulanSoal;
		if (kumpulansoal [nomorSoalDitampilkan].jawabanBenar.ToString().Equals("A")) {
			bta.sprite = btbenar;
		} else {
			bta.sprite = btsalah;
		}

		if (kumpulansoal [nomorSoalDitampilkan].jawabanBenar.ToString().Equals("B")) {
			btb.sprite = btbenar;
		} else {
			btb.sprite = btsalah;
		}

		if (kumpulansoal [nomorSoalDitampilkan].jawabanBenar.ToString().Equals("C")) {
			btc.sprite = btbenar;
		} else {
			btc.sprite = btsalah;
		}

		if (kumpulansoal [nomorSoalDitampilkan].jawabanBenar.ToString().Equals("D")) {
			btd.sprite = btbenar;
		} else {
			btd.sprite = btsalah;
		}

		Debug.Log ("no "+nomorSoalDitampilkan+" . "+kumpulansoal [nomorSoalDitampilkan].jawabanBenar);

	}
}

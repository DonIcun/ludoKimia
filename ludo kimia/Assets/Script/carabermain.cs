using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class carabermain : MonoBehaviour {
	public int langkahcara;
	public string tekscara;
	public Text caramain;
	public Sprite[] spritecara;
	public Image gbcara;
	public GameObject btkanan,btkiri;
	// Use this for initialization
	void Start () {
		langkahcara = 1;

	}
	
	// Update is called once per frame
	void Update () {
		if (langkahcara == 1) {
			btkiri.SetActive (false);
			btkanan.SetActive (true);
		}
		else if (langkahcara == 9) {
			btkiri.SetActive (true);
			btkanan.SetActive (false);
		}
		else{
			btkiri.SetActive (true);
			btkanan.SetActive (true);
		}
			//untuk back ke menu puluhan materi dengan tombol back
			if (Input.GetKeyDown (KeyCode.Escape)) {
				//backmenu ();
				SceneManager.LoadScene("main");
			}
	
	}

	public void klikkanan(){
		langkahcara = langkahcara + 1;
		tampillangkah (langkahcara);
	}
	public void klikkiri (){
		if (langkahcara > 0) {
			langkahcara = langkahcara - 1;
			tampillangkah (langkahcara);
		}
	}
	void tampillangkah(int value){
		switch (value) {
		case 1:
			gbcara.sprite = spritecara[value -1];
			tekscara = langkahcara+ ". Pilih Jumlah Pemain";
			caramain.text = tekscara;
			break;
		case 2:
			gbcara.sprite = spritecara[value -1];
			tekscara = langkahcara + ". tekan tombol hijau bertuliskan \"lempar dadu\" untuk mengacak dadu";
			caramain.text = tekscara;
			break;
		case 3:
			gbcara.sprite = spritecara[value -1];
			tekscara = langkahcara + ". pion pemain akan berjalan sesuai dengan nilai dadu yang muncul. " +
				"\njika nilai dadu = 6, maka pemain bisa mengacak dadu lagi ";
			caramain.text = tekscara;
			break;
		case 4:
			gbcara.sprite = spritecara[value -1];
			tekscara = langkahcara + ". jika pion berhenti di kotak bertanda tanya, maka akan muncul pertanyaan";
			caramain.text = tekscara;
			break;
		case 5:
			gbcara.sprite = spritecara[value -1];
			tekscara = langkahcara + ". jika jawaban benar maka pemain mendapat nilai 10 dan bisa mengacak dadu lagi";
			caramain.text = tekscara;
			break;
		case 6:
			gbcara.sprite = spritecara[value -1];
			tekscara = langkahcara + ". jika jawaban salah maka permainan dilanjutkan giliran pemain selanjutnya";
			caramain.text = tekscara;
			break;		
		case 7:
			gbcara.sprite = spritecara[value -1];
			tekscara = langkahcara + ". permainan selesai jika ada pemain yang bisa menempatkan semua pionnya di titik finish";
			caramain.text = tekscara;
			break;
		case 8:
			gbcara.sprite = spritecara[value -1];
			tekscara = langkahcara + ". di akhir permainan akan ditampilkan skor dari setiap pemain";
			caramain.text = tekscara;
			break;
		case 9:
			gbcara.sprite = spritecara[value -1];
			tekscara = langkahcara + ". pemain juga bisa melihat review jawaban yang benar dari soal yang ada";
			caramain.text = tekscara;
			break;
		}
	}
}

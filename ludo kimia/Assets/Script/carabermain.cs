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
		tampillangkah(1);

	}
	
	// Update is called once per frame
	void Update () {
		if (langkahcara == 1) {
			btkiri.SetActive (false);
			btkanan.SetActive (true);
		}
		else if (langkahcara == 11) {
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
			tekscara = "Pilih Jumlah Pemain. kemudain klik tombol \"bermain\"";
			caramain.text = tekscara;
			break;
		case 2:
			gbcara.sprite = spritecara[value -1];
			tekscara = "Giliran pemain ditunjukkan pada panah merah diatas";
			caramain.text = tekscara;
			break;
		case 3:
			gbcara.sprite = spritecara[value -1];
			tekscara = "Tekan tombol \"lempar dadu\" untuk memulai acak dadu. ";
			caramain.text = tekscara;
			break;
		case 4:
			gbcara.sprite = spritecara[value -1];
			tekscara = "Pemain harus mendapat nilai dadu 6 untuk bisa menjalankan pion pertama kali. ";
			caramain.text = tekscara;
			break;
		case 5:
			gbcara.sprite = spritecara[value -1];
			tekscara = "jika pion pemain berhenti di kotak bertanda tanya,pemain akan mendapat kesempatan untuk menjawab pertanyaan";
			caramain.text = tekscara;
			break;
		case 6:
			gbcara.sprite = spritecara[value -1];
			tekscara = "jika jawaban salah, maka giliran pemain selesai dan dilanjutkan giliran pemain selanjutnya";
			caramain.text = tekscara;
			break;
		case 7:
			gbcara.sprite = spritecara[value -1];
			tekscara = "jika jawaban benar maka pemain mendapat point 10 dan mendapat kesempatan mengacak dadu lagi";
			caramain.text = tekscara;
			break;		
		case 8:
			gbcara.sprite = spritecara[value -1];
			tekscara = "jika pemain mendapat nilai dadu 6,maka pemain mendapat kesempatan untuk mengacak dadu lagi.";
			caramain.text = tekscara;
			break;
		case 9:
			gbcara.sprite = spritecara[value -1];
			tekscara = "permainan selesai jika ada pemain yang bisa menempatkan semua pionnya di titik finish";
			caramain.text = tekscara;
			break;
		case 10:
			gbcara.sprite = spritecara[value -1];
			tekscara = "di akhir permainan akan ditampilkan total perolehan skor dari setiap pemain";
			caramain.text = tekscara;
			break;
		case 11:
			gbcara.sprite = spritecara[value -1];
			tekscara = "pemain juga bisa melihat review jawaban yang benar dari soal yang ada di akhir permainan";
			caramain.text = tekscara;
			break;
		}
	}
}

// Filename : GameManager.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager Singleton;

//	public GameObject gambarPertanyaan;
	public GameObject[] pilihanJawabanButton;
	public GameObject nextButton, previousButton;
	public GameObject kolomJawaban;
	public GameObject panelSoal;
	public GameObject imageSkor;
	public Sprite[] gambSkor;
	public Text teksPertanyaan;
	public Text[] nilaiplayer,nilaifinal;
	public Text tskor;
	//public Text sisaWaktuMengerjakan;
	public Text teksSkor;
	public PaketSoal paketSoal;
	public Jawaban[] jawabanUser;
	//public int waktuMenitMengerjakan = 120;
	public int nomorSoalDitampilkan = 0;
	public static int[] skor;
	public int skortinggi;
	int soalke = -1;
	int soalback;
	private Jawaban jawabanBenar;
	private int jumlahSoal;

//	private int waktuDetik = 0;

	private void Awake()
	{
		Singleton = this;
		//DontDestroyOnLoad(this);
	}

	// Filename : GameManager.cs
	private void Start()
	{
		skor = new int[]{ 0, 0, 0, 0, 0 };
		jumlahSoal	= paketSoal.kumpulanSoal.Length;
		jawabanUser = new Jawaban[jumlahSoal];

		for (int i = 0; i < jawabanUser.Length; i++)
		{
			jawabanUser[i] = Jawaban.Kosong;
		}
		//SetSoal();
		//InvokeRepeating("KurangiWaktuMengerjakan", 2, 1);
		tskor.text =PlayerPrefs.GetInt ("highscore",0).ToString();
	}

	// Filename : GameManager.cs
	public void nextSoal(int i){
		soalke = soalke + i;
		SetSoal (soalke);
	}
	public void prevSoal(int i){
		soalback = nomorSoalDitampilkan - i;
		SetSoal (soalback);
	}
	public void SetSoal(int numsoal)
	{
		panelSoal.SetActive (true);
		teksSkor.text = "....";
		// menunjuk isi array kumpulan soal indeks ke N
		// batasi biar tidak muncul exception Index Out Of Range
		nomorSoalDitampilkan = numsoal;

		// tampilkan soal
		Soal soal			= paketSoal.kumpulanSoal[nomorSoalDitampilkan];
		teksPertanyaan.text = soal.soalPertanyaan;
//		Sprite gambarSoal	= soal.gambarPertanyaan;

		// apakah soal memiliki gambar?
//		if (gambarSoal == null) gambarPertanyaan.SetActive(false);
//		else
//		{
//			gambarPertanyaan.GetComponent<Image>().sprite = gambarSoal;
//			gambarPertanyaan.SetActive(true);
//		}

		// set pilihan jawaban yang ditampilkan
		PilihanJawaban[] pilihanJawaban = soal.pilihanJawaban;

		for (int i = 0; i < pilihanJawabanButton.Length; i++){
			//GameObject teksPilihaJawaban = pilihanJawabanButton [i].GetComponentsInChildren;
			GameObject teksPilihanJawaban	= pilihanJawabanButton[i].transform.Find("TextJawaban").gameObject;
//			GameObject gambarPilihanJawaban = pilihanJawabanButton[i].transform.Find("GambarJawaban").gameObject;
			Button button					= pilihanJawabanButton[i].GetComponentInChildren<Button>();
			button.image.color				= Color.white;

			// apakah ada teks yang perlu ditampilkan?
			if (pilihanJawaban[i].teks != "")
			{				
				teksPilihanJawaban.GetComponent<Text>().text = pilihanJawaban[i].teks;
				teksPilihanJawaban.SetActive(true);
			}
			else teksPilihanJawaban.SetActive(false);

			// apakah ada gambar yang perlu ditampilkan?
//			if (pilihanJawaban[i].gambar)
//			{
//				gambarPilihanJawaban.GetComponent<Image>().sprite = pilihanJawaban[i].gambar;
//				gambarPilihanJawaban.SetActive(true);
//			}
//			else gambarPilihanJawaban.SetActive(false);


			// apakah pemain sudah pernah menjawab soal ini sebelumnya?
			// jika iya, perlihatkan ia menjawab pilihan yang mana (A / B / C / D)
			if (jawabanUser[nomorSoalDitampilkan] != Jawaban.Kosong && (int)jawabanUser[nomorSoalDitampilkan] == i + 1)
			{
				Color selectedAnswerColor = new Color(0f,0f,1f);
				pilihanJawabanButton[i].GetComponentInChildren<Button>().image.color = selectedAnswerColor;
			}
		}
	}

//	// Filename : GameManager.cs
//	private void KurangiWaktuMengerjakan()
//	{
//		waktuDetik++;
//		if(waktuDetik%60 == 0)
//		{
//			waktuDetik = 0;
//			waktuMenitMengerjakan--;
//			sisaWaktuMengerjakan.text = "Sisa waktu : " + waktuMenitMengerjakan + " menit";
//		}
//
//		if (waktuMenitMengerjakan == 0)
//			WaktuHabis();
//	}
//
//	// Filename : GameManager.cs
//	public void WaktuHabis()
//	{
//		SceneManager.LoadScene("NilaiJawaban");
//	}

	// Filename : GameManager.cs
	public void SetJawaban(int jawaban)
	{
		jawabanUser[nomorSoalDitampilkan] = (Jawaban)jawaban;
		cekSkor (nomorSoalDitampilkan);
		skorfinal ();
	}
		
	public void cekSkor(int i){
		Soal[] kumpulanSoal = paketSoal.kumpulanSoal;
		if (jawabanUser [i] == kumpulanSoal [i].jawabanBenar) {
			int nowplayer = diceRoll.player;
			Debug.Log (nowplayer);
			skor[nowplayer] += 10;
			nilaiplayer [nowplayer].text = skor[nowplayer].ToString ();
			nilaifinal [nowplayer-1].text = skor [nowplayer].ToString ();
			teksSkor.text = "Jawaban Benar, silahkan acak dadu lagi";
			imageSkor.GetComponent<Image> ().sprite = gambSkor [1];
			if (playerControl.tempDadu == 6) {
				Debug.Log ("jawaban benar nilai dadu 6");
			} else {
				diceRoll.langkah -= 1;
				Debug.Log("Jawaban jawabanBenar Nilai dadu != 6");
			}
		} else {
			teksSkor.text = "Jawaban Salah,lanjut ke pemain selanjutnya";
			imageSkor.GetComponent<Image> ().sprite = gambSkor [2];
			if(playerControl.tempDadu == 6){
				diceRoll.langkah += 1;
			}
		}
		StartCoroutine ("closeSoal");
		Debug.Log("soal "+i+" jawaban user = "+jawabanUser[i] + " | jawaban benar = " + kumpulanSoal[i].jawabanBenar);
	}

	public void skorfinal(){
		for (int i = 0; i <= 4; i++) {
			if (skor [i] > PlayerPrefs.GetInt("highscore",0)) {
				//skortinggi = skor [i];
				PlayerPrefs.SetInt ("highscore",skor[i]);
				tskor.text = skor[i].ToString();
			}
		}
	}

	public void resetscore(){
		PlayerPrefs.DeleteKey ("highscore");
		tskor.text =PlayerPrefs.GetInt ("highscore",0).ToString();
	}

	public IEnumerator closeSoal(){
		for (int i = 0; i < 5; i++) {
			yield return new WaitForSeconds (0.25f);
			Debug.Log ("WaitUntil i = " + i);
			if (i == 4) {
				imageSkor.GetComponent<Image> ().sprite = gambSkor [0];
				teksSkor.text = "....";
				panelSoal.SetActive(false);
			}
		}	
	}


}
//\x208x < untuk subscribt
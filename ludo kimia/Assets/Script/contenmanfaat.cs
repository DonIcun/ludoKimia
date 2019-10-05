using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class contenmanfaat : MonoBehaviour {
	public Image gbmateri;
	public Sprite he,ne,ar,kr,xe,rn;
	public string txtjudul, txtmateri,txmanfaat;
	public Text judul,materi,manfaat;

	// Use this for initialization
	void Start () {
		gbmateri.gameObject.SetActive(false);
		helium ();
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("materi");
		}
			
	}

	public void helium(){
		gbmateri.gameObject.SetActive(true);
		txmanfaat = "Balon helium";
		manfaat.text = txmanfaat;
		txtjudul = "Helium";
		gbmateri.sprite = he;
		txtmateri = "\n\tHelium digunakan sebagai:" +
			"\n 1. pengisi balon meteorologi maupun kapal balon karena gas ini mempunyai rapatan yang paling rendah setelah hidrogen dan tidak dapat terbakar. " +
			"\n\n 2. Dalam jumlah besar helium digunakan untuk membuat atmosfer inert, untuk berbagai proses yang terganggu oleh udara misalnya pada pengelasan. " +
			"Suatu penggunaan lain yang menarik dari helium adalah bahan campuran 80 persen helium 20 persen oksigen yang dipakai untuk menggantikan udara pernafasan penyelam dan orang lain yang bekerja di bawah tekanan tinggi. \n\n";
		materi.text = txtmateri;
		judul.text = txtjudul;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}

	public void neon(){
		gbmateri.gameObject.SetActive(true);
		txmanfaat = "Lampu Reklame";
		manfaat.text = txmanfaat;
		txtjudul = "Neon";
		gbmateri.sprite = ne;
		txtmateri = "\n\t Neon digunakan sebagai:" +
			"\n 1. membuat lampu-lampu reklame yang memberi warna merah. Neon cair juga digunakan sebagai pendingin untuk menciptakan suhu rendah, " +
			"\n\n 2. membuat indikator tegangan tinggi, penangkal petir dan tabung-tabung televisi. " +
			"\n\n 3. Neon cair merupakan zat pendingin (refrigeran) untuk suhu rendah yang ekonomis.\n\n";
		materi.text = txtmateri;
		judul.text = txtjudul;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
	public void argon(){
		gbmateri.gameObject.SetActive(true);
		txmanfaat = "Lampu Pijar";
		manfaat.text = txmanfaat;
		txtjudul = "Argon";
		gbmateri.sprite = ar;
		txtmateri = "\n\t Argon digunakan sebagai:" +
			"\n 1. sebagai pengganti helium untuk menciptakan atmosfer inert. " +
			"\n\n 2. pengisi lampu pijar karena tidak bereaksi dengan kawat wolfram yang panas sampai putih, tidak seperti nitrogen atau oksigen. " +
			"\n\n 3. Pengelasan titanium dan lain-lain logam yang eksotik (istimewa) dalam konstruksi pesawat udara dan roket, memerlukan atmosfer yang lamban, dan argon memenuhi tujuan ini. \n\n";
		materi.text = txtmateri;
		judul.text = txtjudul;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
	public void kripton(){
		gbmateri.gameObject.SetActive(true);
		txmanfaat = "Lampu fluoresensi";
		manfaat.text = txmanfaat;
		txtjudul = "Kripton";
		gbmateri.sprite = kr;
		txtmateri = "\n\t Kripton digunakan bersama sama dengan argon untuk:" +
			"\n 1. pengisi lampu fluoresensi(lampu tabung). " +
			"\n\n 2. lampu kilat fotografi berkecepatan tinggi.Salah satu spektrumnya digunakan sebagai standar panjang untuk meter.  ";
		materi.text = txtmateri;
		judul.text = txtjudul;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
	public void xenon(){
		gbmateri.gameObject.SetActive(true);
		txmanfaat = "Lampu strobo";
		manfaat.text = txmanfaat;
		txtjudul = "Xenon";
		gbmateri.sprite = xe;
		txtmateri = "\n\t Xenon digunakan sebagai:" +
			"\n 1. pembuatan tabung elektron. " +
			"\n\n 2. bidang atom dalam ruang gelembung. " +
			"\n\n 3. pembuatan lampu stroboskopik dan lampu bakterisid. \t" +
			"Salah satu isotop diproduksi secara sintetik, xenon-133, diterapkan sangat bermanfaat sebagai radioisotop. \n\n";
		materi.text = txtmateri;
		judul.text = txtjudul;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
	public void radon(){
		gbmateri.gameObject.SetActive(true);
		txmanfaat = "Terapi radiasi bagi penderita kanker";
		manfaat.text = txmanfaat;
		txtjudul = "Radon";
		gbmateri.sprite = rn;
		txtmateri = "\n\tGas radon bersifat radioaktif sehingga banyak digunakan untuk:" +
			"\n 1. terapi radiasi bagi penderita kanker dengan memanfaatkan sinar yang dihsilkan. " +
			"Namun demikian, jika radon terhisap dalam jumlah cukup banyak akan menimbulkan kanker paru-paru. " +
			"\n\n 2. Karena peluruhan yang cukup cepat, radon digunakan dalam penyelidikan hidrologi yang mengkaji interaksi antara air bawah tanah, anak sungai dan sungai. " +
			"\n\n 3. Radon juga dapat berperan sebagai peringatan gempa karena bila lempengan bumi bergerak kadar radon akan berubah sehingga bisa diketahui bila adanya gempa dari perubahan kadar radon. \n";
		materi.text = txtmateri;
		judul.text = txtjudul;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
}

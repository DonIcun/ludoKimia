using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class contenmanfaat : MonoBehaviour {
	public Image gbmateri;
	public Sprite he,ne,ar,kr,xe,rn;
	public string txtmateri;
	public Text materi;

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
		gbmateri.sprite = he;
		txtmateri = "\n\tHelium digunakan sebagai pengisi balon meteorologi maupun kapal balon karena gas ini mempunyai rapatan yang paling rendah setelah hidrogen dan tidak dapat terbakar. " +
			"Dalam jumlah besar helium digunakan untuk membuat atmosfer inert, untuk berbagai proses yang terganggu oleh udara misalnya pada pengelasan. " +
			"Suatu penggunaan lain yang menarik dari helium adalah bahan campuran 80 persen helium 20 persen oksigen yang dipakai untuk menggantikan udara pernafasan penyelam dan orang lain yang bekerja di bawah tekanan tinggi. \n\n";
		materi.text = txtmateri;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}

	public void neon(){
		gbmateri.gameObject.SetActive(true);
		gbmateri.sprite = ne;
		txtmateri = "\n\tNeon digunakan untuk membuat lampu-lampu reklame yang memberi warna merah. " +
			"Neon cair juga digunakan sebagai pendingin untuk menciptakan suhu rendah, " +
			"juga digunakan untuk membuat indikator tegangan tinggi, penangkal petir dan tabung-tabung televisi." +
			" Neon cair merupakan zat pendingin (refrigeran) untuk suhu rendah yang ekonomis.\n\n";
		materi.text = txtmateri;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
	public void argon(){
		gbmateri.gameObject.SetActive(true);
		gbmateri.sprite = ar;
		txtmateri = "\n\tArgon dapat digunakan sebagai pengganti helium untuk menciptakan atmosfer inert. " +
			"Juga digunakan untuk pengisi lampu pijar karena tidak bereaksi dengan kawat wolfram yang panas sampai putih, tidak seperti nitrogen atau oksigen. " +
			"Pengelasan titanium dan lain-lain logam yang eksotik (istimewa) dalam konstruksi pesawat udara dan roket, memerlukan atmosfer yang lamban, dan argon memenuhi tujuan ini.\n\n";
		materi.text = txtmateri;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
	public void kripton(){
		gbmateri.gameObject.SetActive(true);
		gbmateri.sprite = kr;
		txtmateri = "\n\tKripton digunakan bersama-sama dengan argon untuk pengisi lampu fluoresensi ( lampu tabung ). " +
			"Juga untuk lampu kilat fotografi berkecepatan tinggi. " +
			"Salah satu spektrumnya digunakan sebagai standar panjang untuk meter. \n\n";
		materi.text = txtmateri;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
	public void xenon(){
		gbmateri.gameObject.SetActive(true);
		gbmateri.sprite = xe;
		txtmateri = "\n\tXenon digunakan dalam pembuatan tabung elektron. Juga digunakan dalam bidang atom dalam ruang gelembung. " +
			"Selain itu, juga digunakan dalam pembuatan lampu stroboskopik dan lampu bakterisid. " +
			"Salah satu isotop diproduksi secara sintetik, xenon-133, diterapkan sangat bermanfaat sebagai radioisotop.\n\n";
		materi.text = txtmateri;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
	public void radon(){
		gbmateri.gameObject.SetActive(true);
		gbmateri.sprite = rn;
		txtmateri = "\n\tGas radon bersifat radioaktif sehingga banyak digunakan dalam terapi radiasi bagi penderita kanker dengan memanfaatkan sinar yang dihsilkan. " +
			"Namun demikian, jika radon terhisap dalam jumlah cukup banyak akan menimbulkan kanker paru-paru. " +
			"Karena peluruhan yang cukup cepat, radon digunakan dalam penyelidikan hidrologi yang mengkaji interaksi antara air bawah tanah, anak sungai dan sungai. " +
			"Radon juga dapat berperan sebagai peringatan gempa karena bila lempengan bumi bergerak kadar radon akan berubah sehingga bisa diketahui bila adanya gempa dari perubahan kadar radon.\n";
		materi.text = txtmateri;
		materi.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
}

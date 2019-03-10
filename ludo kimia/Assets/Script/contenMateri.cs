using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class contenMateri : MonoBehaviour {
	public Text isiMateri,isimateri2,judul;
	string teksjudul,teksmateri,teksmateri2;
	public TextAsset asetmateri;
	public GameObject gambarmateri,gambarmateri2;
	public Sprite gbMateri;
	public GameObject canvas1, canvas2;
	public ScrollRect scroller;
	public bool canback;

	// Use this for initialization
	void Start () {
		canback = false;
		canvas1.SetActive (true);
//		gasmulia ();
//		sifatunsur();
		senyawa ();
	}

	void Update(){
		//untuk back ke menu puluhan materi dengan tombol back
		if(canback){
			if (Input.GetKeyDown (KeyCode.Escape)) {
				backmenu ();
			}
		}
	}
	public void loadtext(int value){
		canvas1.SetActive (false);
		switch (value) {
		case 1:
			gasmulia ();
			break;
		case 2:
			sifatunsur ();
			break;
		case 3:
			senyawa ();
			break;
		}
		scroller.verticalNormalizedPosition = 1f;
		canback = true;
	}
	public void backmenu(){
		canback = false;
		canvas1.SetActive (true);	
	}



	public void gasmulia(){
		gambarmateri.SetActive(false);
		gambarmateri2.SetActive (false);
		isiMateri.gameObject.SetActive (false);
		teksjudul = "Gas Mulia";
		teksmateri ="\n Gas mulia adalah sebutan untuk unsur-unsur golongan VIIIA." +
			"Unsur-unsur gas mulia adalah helium (He), neon (Ne), argon (Ar), kripton (Kr), xeon (Xe), dan radon (Rn)." +
			"Gas mulia diperoleh dari udara bebas, kecuali radon diperoleh dari rongga batuan uranium. " +
			"Helium selain diperoleh dari udara bebas juga dapat diperoleh dari pemisahan gas alam. " +
			"Gas mulia merupakan golongan unsur yang paling stabil. " +
			"Hal penting yang menyebabkan gas mulia amat stabil yaitu konfigurasi elektronnya. " +
			"\n\n \u2082He : 1s\u00B2  \n" +
			"\u2081\u2080Ne : 1s\u00b2 2s\u00b2 2p\u2076\n" +
			"\u2081\u2088Ar : 1s\u00b2 2s\u00b2 2p\u2076 3s\u00b2 3p\u2076 \n" +
			"\u2083\u2086Kr : 1s\u00b2 2s\u00b2 2p\u2076 3s\u00b2 3p\u2076 4s\u00b2 3d\u00b9\u2070 4p\u2076 \n" +
			"\u2085\u2084Xe : 1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s\u00b2 4d\u00b9\u2070 5p\u2076\n" +
			"\u2088\u2086Rn : 1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s2 4f\u00b9\u2074 5d¹\u2070 6p\u2076" +
			"\n \n Suatu unsur dikatakan stabil apabila unsur tersebut memiliki elektron valensi 2 ( duplet ) atau 8 ( oktet ). " +
			"\n\nSemua unsur golongan 18 berupa gas monoatomik pada temperatur kamar, tidak berwarna, dan tidak berbau, tidak terbakar dan juga tidak mendukung pembakaran. " +
			"Titik leleh dan titik didih yang sangat rendah karena gaya dispersi yang mengikat atom-atomnya dalam fase padat dan fase cair sangat rendah. \n\n";
		judul.text = teksjudul;
		isimateri2.text = teksmateri;
		isimateri2.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
	public void sifatunsur(){
		gambarmateri.SetActive (false);
		gambarmateri2.SetActive (true);
		isiMateri.gameObject.SetActive (true);
		isimateri2.gameObject.SetActive (true);
		gbMateri = Resources.Load<Sprite> ("gambar unsur");
		teksjudul="Sifat Unsur Gas Mulia";
		teksmateri="\n\tArgon, kripton, dan xenon sedikit larut dalam air, sebab atom-atom gas mulia ini dapat terperangkap dalam rongga-rongga kisi molekul air membentuk struktur klarat. " +
			"Beberapa data tentang gas mulia dapat dilihat pada tabel di bawah ini:\n";
		gambarmateri2.GetComponent<Image> ().sprite = gbMateri;
		teksmateri2="\nDalam waktu yang singkat, ahli riset menunjukkan bahwa xenon dapat bereaksi langsung dengan fluor untuk membentuk senyawaan-senyawaan biner sederhana, " +
			"seperti XeF\u2082, XeF\u2084, dan XeF\u2086. Istilah lamban (inert) tidak lagi sesuai, kebanyakan ahli kimia mulai menyebut keluarga itu gas mulia." +
			"\tRadon akan bereaksi spontan dengan fluor pada suhu kamar, sementara xenon memerlukan pemanasan atau permulaan reaksi secara fotokimia. " +
			"Kripton dengan fluor hanya bila keduanya dikenakan penyinaran atau pelepasan muatan listrik. \n\n";
		judul.text = teksjudul;
		isiMateri.text = teksmateri;
		isimateri2.text = teksmateri2;
		isiMateri.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
		isimateri2.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
	public void senyawa(){
		gambarmateri.SetActive(false);
		gambarmateri2.SetActive (false);
		isiMateri.gameObject.SetActive (false);
		teksjudul = "Senyawaan Gas Mulia";
		teksmateri = "\n\n\tFluorida XeF\u2082, XeF\u2084, dan XeF\u2086 diperoleh dengan mereaksikan xenon dengan fluor dalam kuantitas yang makin bertambah. " +
			" Dalam senyawaan-senyawaan ini, xenon mempunyai bilangan oksidasi genap+2, +4, dan +6 yang khas kebanyakan senyawaan xenon. " +
			" Senyawaan dalam sebuah atom oksigen menggantikan dua atom fluor dalam heksafluorida juga dikenal : " +
			"XeOF\u2084, XeO\u2082F\u2082, dan XeO\u2083. Senyawa XeO\u2083, stabil dalam larutan air, " +
			"tetapi zat padatnya yang putih dan kering adalah bahan peledak (eksplisif) yang dahsyat dan secara membahayakan peka terhadap ledakan hebat (detonasi), " +
			"sebagaimana telah ditunjukkan oleh kecelakaan ledakan dalam laboraturium. " +
			"\n\n\tBerikut merupakan beberapa reaksi unsur gas mulia dengan unsur lain :" +
			"\nSenyawa Xenon Fluor\n" +
			"\nXenon dapat bereaksi langsung dengan fluor dan senyawa oksigen dapat diperoleh dari senyawa Xenon fluorida. " +
			"\n\n1.   Xenon difluorida\n " +
			"\n\tSenyawa XeF\u2082 dibuat dengan interaksi Xe dengan kekurangan F\u2082 pada tekanan tinggi. " +
			"Ia larut dalam air menghasilkan larutan dengan bau tajam XeF\u2082. " +
			"Hidrolisis berlangsung lambat namun cepat dengan adanya basa " +
			"\n\n\t XeF\u2082 + 2OH–  ->  Xe +1/2O\u2082 +2F–  + H\u2082O" +
			"\n\n\tXeF₂ juga dapat terbentuk dari xenon padat direaksikan dengan difluora oksida pada suhu 12\u00b0C. " +
			"\n\n\tXe(s)  +  F\u2080O(g)  ->  XeF\u2082(S) +1/2O\u2082(g)" +
			"\n\n\tXeF\u2082 pereaksi yang baik untuk reaksi flourinasi benzene yaitu untuk mensubsitusi atom H pada benzene dengan atom F" +
			"\n\tC\u2086H\u2086 + XeF\u2082  ->  C\u2086H\u2085F  + Xe  + HF" +
			"\n\n2.   Xenon tetraflourida (XeF\u2084)\n" +
			"\n\tSenyawa XeF\u2084 dibuat dari memenaskan Xe dan F\u2082 pada suhu 400\u00b0C dan tekanan 6 atm dengan katalis nikel,tetapi dikotori oleh XeF\u2082 lebih banyak. " +
			"Sebaiknya bila perbandingan itu besar maka XeF\u2084 yang banyak. " +
			"\n\n\tXeF\u2082  + F\u2082  ->  XeF\u2084" +
			"\n\n3.   Xenon heksaflourida (XeF\u2086)\n" +
			"\n\tSenyawa ini diperoleh dengan interaksi XeF\u2084 dan F\u2082 dibawah tekanan atau langsung dari Xe dan flour pada suhu diatas 250\u00b0C dan tekanan >50 atm. " +
			"XeF\u2086 pada suhu kamar (25\u00b0C,1 atm) berbentuk kristal berwarna dengan titik leleh 48°C.bentuk molekulnya diduga octahedral yang terdistarsi atau secara teori segi lima piramida. " +
			"\n\tXeF\u2086  luar biasa reaktif, dapat bereaksi dengan silica membentuk senyawa oksi gas mulia yang paling stabil, reaksinya sebagai berikut :" +
			"\n\n\tSrO\u2082 (s) + 2XeF\u2086(g)  ->  SiF\u2084 + 2XeOF\u2084(g)" +
			"\n\n\tPada suhu kamar XeOF4 berbentuk cairan tak berwarna. " +
			"Molekul XeOF\u2084 dan XeO\u2082 berbentuk segi empat piramida dan segitiga piramida. " +
			"XeF\u2086 dapat bertindak sebagai garam terhadap F– dan dapat diubah menjadi heptafluoroheksat. " +
			"\n\n\tXeF\u2086 + RbF  ->  RbXeF\u2087 " +
			"\n\n\tGaram Rb dan Cs adalah senyawaan xenon yang paling stabil yang dikenal dan terdekomposisi hanya di atas 400\u00b0C. " +
			"garam natrium kurang stabil dan dapat digunakan untuk memurnikan XeF\u2086 karena ia terdekomposisi di bawah 100\u00b0C. " +
			"\n\n";
		judul.text = teksjudul;
		isimateri2.text = teksmateri;
		isimateri2.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}
}
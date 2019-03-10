using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class contentsenyawa : MonoBehaviour {
	public GameObject materi2;
	public Text isiMateri,judul,isimateri2,isimateri3,submateri,subjudul;
	string teksjudul,teksmateri,teksmateri2,teksmateri3,teksubjudul,teksubmateri;
	public Image gbsubmateri;
	public Sprite gb1,gb2,gb3,gb4,gb5;
	public TextAsset asetmateri;
	public ScrollRect scroller;
	public bool canback;

	// Use this for initialization
	void Start () {
		senyawa ();
		materi2.SetActive (false);
	}

	void Update(){
		//untuk back ke menu puluhan materi dengan tombol back
			if (Input.GetKeyDown (KeyCode.Escape)) {
				//backmenu ();
				SceneManager.LoadScene("materi");
			}
	}


	public void senyawa(){
		teksjudul = "Senyawaan Gas Mulia";
		teksmateri = "\n\n\tFluorida XeF\u2082, XeF\u2084, dan XeF\u2086 diperoleh dengan mereaksikan xenon dengan fluor dalam kuantitas yang makin bertambah. " +
		" Dalam senyawaan-senyawaan ini, xenon mempunyai bilangan oksidasi genap+2, +4, dan +6 yang khas kebanyakan senyawaan xenon. " +
		" Senyawaan dalam sebuah atom oksigen menggantikan dua atom fluor dalam heksafluorida juga dikenal : " +
		"XeOF\u2084, XeO\u2082F\u2082, dan XeO\u2083. Senyawa XeO\u2083, stabil dalam larutan air, " +
		"tetapi zat padatnya yang putih dan kering adalah bahan peledak (eksplisif) yang dahsyat dan secara membahayakan peka terhadap ledakan hebat (detonasi), " +
		"sebagaimana telah ditunjukkan oleh kecelakaan ledakan dalam laboraturium. " +
		"\n\n\tBerikut merupakan beberapa reaksi unsur gas mulia dengan unsur lain :";
	
		teksmateri2 = "Senyawa xenon dalam bentuk garam yang telah berhasil dibuat adalah garam dari xenon dengan fluor. " +
			"Seperti XePtF\u2086 , CeXeF\u2086, CsXeF\u2088, NaHXeO\u2084 dan Na\u2084XeO₆";
		teksmateri3 = "Senyawa radon dapat bereaksi spontan dengan fluorin tetapi waktu hidupnya singkat karena radon merupakan unsure radiaktif. " +
			"Senyawa krypton hanya membentuk senyawa dengan tingkat oksidasi +2 membentuk senyawa KrF\u2082. " +
			"Radon dapat bereaksi dengan F\u2082 dan menghasilkan RnF\u2082 hanya saja senyawa KrF\u2082 dan RnF\u2082 bersifat tidak stabil.";
		judul.text = teksjudul;
		isiMateri.text = teksmateri;
		isimateri2.text = teksmateri2;
		isimateri3.text = teksmateri3;
		isiMateri.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
		isimateri2.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
		isimateri3.GetComponent<ContentSizeFitter> ().SetLayoutVertical ();
	}

	public void materi(int menumateri){
		materi2.SetActive (true);
		switch (menumateri) {
		case 1:
			teksubjudul = "Xenon Diflourida";
			teksubmateri = "\tSenyawa XeF\u2082 dibuat dengan interaksi Xe dengan kekurangan F\u2082 pada tekanan tinggi. " +
			"Ia larut dalam air menghasilkan larutan dengan bau tajam XeF\u2082. " +
			"Hidrolisis berlangsung lambat namun cepat dengan adanya basa" +
			"\nXeF\u2082 + 2OH– -> Xe +½O\u2082 +2F–  + H\u2082O" +
			"\n\n\tXeF\u2082 juga dapat terbentuk dari xenon padat direaksikan dengan difluora oksida pada suhu 120C." +
			"\nXe(s)  +  F\u2082O(g) -> XeF\u2082(S) +½O\u2082(g)" +
			"\n\n\tXeF\u2082 pereaksi yang baik untuk reaksi flourinasi benzene yaitu untuk mensubsitusi atom H pada benzene dengan atom F" +
			"\nC\u2086H\u2086 + XeF\u2082 -> C\u2086H\u2085F  + Xe  + HF";
			gbsubmateri.sprite = gb1;
			subjudul.text = teksubjudul;
			submateri.text = teksubmateri;
			break;
		case 2:
			teksubjudul = "Xenon Tetraflourida(XeF₄)";
			teksubmateri = "\tSenyawa XeF\u2084 dibuat dari memenaskan Xe dan F\u2082 pada suhu 400°C dan tekanan 6 atm dengan katalis nikel," +
				"tetapi dikotori oleh XeF\u2082 lebih banyak. " +
				"Sebaiknya bila perbandingan itu besar maka XeF\u2084 yang banyak." +
				"\nXeF\u2082  + F\u2082 -> XeF\u2084";
			gbsubmateri.sprite = gb2;
			subjudul.text = teksubjudul;
			submateri.text = teksubmateri;
			break;
		case 3:
			teksubjudul = "Xenon heksafluida";
			teksubmateri = "\tSenyawa ini diperoleh dengan interaksi XeF\u2084 dan F\u2082 dibawah tekanan atau langsung dari Xe dan flour pada suhu diatas 250°C dan tekanan >50 atm. " +
			"XeF\u2086 pada suhu kamar (25°C,1 atm) berbentuk kristal berwarna dengan titik leleh 48°C." +
			"bentuk molekulnya diduga octahedral yang terdistarsi atau secara teori segi lima piramida." +
			"\n\n\tXeF\u2086  luar biasa reaktif, dapat bereaksi dengan silica membentuk senyawa oksi gas mulia yang paling stabil, reaksinya sebagai berikut :" +
			"\nSrO\u2082 (s) + 2XeF\u2086(g) -> SiF\u2084 + 2XeOF\u2084(g)" +
			"\n\n\tPada suhu kamar XeOF\u2084 berbentuk cairan tak berwarna. " +
			"Molekul XeOF\u2084 dan XeO\u2082 berbentuk segi empat piramida dan segitiga piramida." +
			"XeF\u2086 dapat bertindak sebagai garam terhadap F– dan dapat diubah menjadi heptafluoroheksat." +
			"\nXeF\u2086 + RbF -> RbXeF\u2087 " +
				"\n\n\tGaram Rb dan Cs adalah senyawaan xenon yang paling stabil yang dikenal dan terdekomposisi hanya di atas 400°C. " +
				"garam natrium kurang stabil dan dapat digunakan untuk memurnikan XeF\u2086 karena ia terdekomposisi di bawah 100°C.";
			gbsubmateri.sprite = gb3;
			subjudul.text = teksubjudul;
			submateri.text = teksubmateri;
			break;
		case 4:
			teksubjudul = "Xenon Trioksida(XeO\u2083)";
			teksubmateri = "\tSenyawa XeO\u2083 dibentuk dalam hidrolisis XeF\u2084 dan XeF\u2086" +
				"\n3XeF\u2084 + 6H\u2082O -> XeO\u2083 + 2Xe + 3/2O\u2082 +12Hf" +
				"\nXeF\u2086 + 3H\u2082O -> XeO\u2083 + 6HF" +
				"\n\n\tLarutan XeO\u2083 tiak berwarna, tidak berbau dan stabil. " +
				"Dalam penguapan XeO\u2083 diperoleh sebagai suatu padatan putih yang mudah menguap di udara yang berbahaya karena mudah meledak. " +
				"Dalam larutan yang bersifat basa, ion xenat (IV) dibentuk " +
				"\nXeO\u2083 + OH– -> HXeO\u2084-" +
				"\n\n\tNamun ion HXeO₄- disproporsionasi lambat menghasilkan ion Ksenat (IV) atau persenat." +
				"\n2HXe\u2084- + 2OH– -> XeO₆⁴- + Xe + O\u2082 + 2H\u2082O" +
				"\n\n\tPersenat dibentuk tidak hanya dengan disproporsionasi HXeO–\u2084 namun juga bila mana ion ini dioksidasi dengan ozon. " +
				"Larutan perxenat merupakan pengoksidasi yang kuat dan cepat. " +
				"Dalam larutan alkali bentuk utama ialah ion HXeO\u1082-\u2086 dan persenat hanya direduksi lambat oleh air. " +
				"Meskipun demikian dalam larutan asam reaksinya berlangsung segera :" +
				"HXeO²-\u2086 + H+ -> HXeO–\u2084 + ½O\u2082 + H\u2082O";
			gbsubmateri.sprite = gb4;
			subjudul.text = teksubjudul;
			submateri.text = teksubmateri;
			break;
		case 5:
			teksubjudul = "Xenon Tetraoksida(XeO\u2084)";
			teksubmateri = "Apabila barium persenat dipanaskan dengan H\u2082SO\u2084 pekat xenon tetraoksida terbentuk sebagai gas yang mudah meledak dan sangat tidak stabil.";
			gbsubmateri.sprite = gb5;
			subjudul.text = teksubjudul;
			submateri.text = teksubmateri;
			break;
		}
	

	}
}
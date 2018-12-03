using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memilihPlayer : MonoBehaviour {
	public RectTransform[] titikDadu;

	public static int indexPemain = 0;

	// Use this for initialization
	void Start () {
		transform.position = titikDadu [indexPemain].transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = titikDadu [indexPemain].transform.position;
	}
}

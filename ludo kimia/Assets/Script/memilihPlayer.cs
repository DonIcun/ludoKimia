using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memilihPlayer : MonoBehaviour {
	public RectTransform[] titikDadu;


	// Use this for initialization
	void Start () {
		transform.position = titikDadu [diceRoll.player].transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = titikDadu [diceRoll.player].transform.position;
	}
}

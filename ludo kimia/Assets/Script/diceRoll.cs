using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diceRoll : MonoBehaviour {

	public Text hasilRandom;
	public string nilaiDadu;
	public Sprite[] dice;


	System.Random randomDice = new System.Random();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RollDice(){
		int randNum = randomDice.Next (1, 7);
		nilaiDadu = randNum.ToString();
		hasilRandom.text = nilaiDadu;

	}
}

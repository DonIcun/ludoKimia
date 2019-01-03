using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bermainControl : MonoBehaviour {
	public RectTransform[] waypoint;
	public GameObject btrollDice ;
	public GameObject eventSystem;
	int players,pion;
	//private float moveSpeed = 1f;

	[HideInInspector]
	public int waypointindex = 0;
	public int waypointGoal = 0;

	public bool moveAllowed = false;

	// Use this for initialization
	void Start () {
		transform.position = waypoint [waypointindex].transform.position;
		btrollDice = GameObject.Find ("ButtonLempar");
		eventSystem = GameObject.Find ("EventSystem");
	}
	
	// Update is called once per frame
	void Update () {

	}
		

	public void Move(string playertomove){
		string[] splitParams= playertomove.Split(',');
		players = int.Parse(splitParams [0]);
		pion = int.Parse(splitParams [1]);
		waypointGoal = playerControl.players[players,pion];
		if (waypointindex != waypointGoal) {
			StartCoroutine ("jalanmaju");
		} else {
			Debug.Log ("player "+players+" pion ke "+pion+" tidak jalan");
		}
		//diceRoll.diceAllowed = true;
		playerControl.playerPos = 0;
	}

	public void moveBackward(){
		waypointGoal = 0;
		Debug.Log ("player ["+players+"]-[ "+pion+"] di kick ke home");
		StartCoroutine ("jalanmundur");
	}

	public IEnumerator jalanmaju()
	{
		//waypointindex = playerControl.playerPos;
		for (int i = waypointindex ; i <= waypointGoal; i++) {
			transform.position = waypoint [i].transform.position;
			yield return new WaitForSeconds (0.1f);
			Debug.Log ("jalan ke: "+ i+ "_tujuan: "+ waypointGoal);
			btrollDice.GetComponent<Button>().enabled=false ;
		}
		waypointindex = waypointGoal;
		btrollDice.GetComponent<Button>().enabled=true ;
		if (waypointindex == waypointGoal) {
			eventSystem.GetComponent<playerControl> ().cekPosSama (players,pion);

		}
		if (waypointindex >= 57) {
			sampaiFinis ();	
		}
	}
	public IEnumerator jalanmundur(){
		for (int i=waypointindex ; i >= waypointGoal; i--) {
			transform.position = waypoint [i].transform.position;
			yield return new WaitForSeconds (0.03f);
			btrollDice.GetComponent<Button>().enabled=false ;
			Debug.Log ("jalan ke: "+ i+ "_tujuan: "+ waypointGoal);
		}
		waypointindex = waypointGoal;
		btrollDice.GetComponent<Button>().enabled=true ;
	}

	public void sampaiFinis(){
		this.gameObject.GetComponent<Button> ().enabled = false;
		Debug.Log (this.gameObject.name + "this pion is finis"); 
	}
		
}

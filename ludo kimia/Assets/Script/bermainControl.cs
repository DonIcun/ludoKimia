using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bermainControl : MonoBehaviour {
	public RectTransform[] waypoint;
	//private float moveSpeed = 1f;

	[HideInInspector]
	public int waypointindex = 0;
	public int waypointGoal = 0;

	public bool moveAllowed = false;

	// Use this for initialization
	void Start () {
		transform.position = waypoint [waypointindex].transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

	public void Move(){
		waypointGoal = playerControl.playerPos;
		StartCoroutine ("jalanmaju");
		diceRoll.diceAllowed = true;
		playerControl.playerPos = 0;
	}

	public IEnumerator jalanmaju()
	{
		//waypointindex = playerControl.playerPos;
		for (int i = waypointindex ; i <= waypointGoal; i++) {
			transform.position = waypoint [i].transform.position;
			yield return new WaitForSeconds (0.1f);
			Debug.Log ("jalan ke: "+ i+ "_tujuan: "+ waypointGoal);
		}
		waypointindex = waypointGoal;
	}
	public IEnumerator jalanmundur(){
		for (int i=waypointindex ;i >=waypointGoal; i--) {
			transform.position = waypoint [i].transform.position;
			yield return new WaitForSeconds (0.1f);
		}
		waypointindex = waypointGoal;
	}
		
}

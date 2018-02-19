using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public PlayerController thePlayer;
	private Vector3 lastPlayerPosition;
	private float distanceToMove;



	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController>();
		// saving the last position of the player //
		lastPlayerPosition = thePlayer.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		// having the distance from last position to current position //
		distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;
		// move the camera as much as the distance 

		//only moving on X along
		transform.position = new Vector3(transform.position.x+distanceToMove,
				transform.position.y,transform.position.z);

		lastPlayerPosition = thePlayer.transform.position;
		
	}
}

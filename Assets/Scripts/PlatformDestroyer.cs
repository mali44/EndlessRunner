﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour {

	public GameObject platformDestructionPoint;


	// Use this for initialization
	void Start () {
		platformDestructionPoint = GameObject.Find("PlatformDestructionPoint");

		
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.x < platformDestructionPoint.transform.position.x){
			//Destroy(gameObject);
			//Destroy(gameObject);
			Debug.Log("AAA");
			gameObject.SetActive(false);
		}

		Debug.Log("TPx  = "+ transform.position.x);
		Debug.Log("PDSTRTPX = "+ platformDestructionPoint.transform.position.x);
		
	}
}

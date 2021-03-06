﻿using System.Collections;
//using System.Collections.Generic;
using UnityEngine;


public class PlatformGenerator : MonoBehaviour {

	public GameObject  thePlatform; //2x1 3x1 5x1 6x1 platform width's
	public Transform GenerationPoint;
	public float distanceBetween;
	public float platformWidth;

	//Generating random distance platform
	public float distanceBetweenMin;
	public float distanceBetweenMax;
	public GameObject[] thePlatforms;
	
	private int platformSelector;
	private float [] platformWidths;

	//public ObjectPooler theObjectPool;


	// Use this for initialization
	void Start () {

		//width amount all of platforms

		//platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
		platformWidths = new float[thePlatforms.Length];
		for (int i =0; i<thePlatforms.Length;i++){
			platformWidths[i]= thePlatforms[i].GetComponent<BoxCollider2D>().size.x;
		}
	
		
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.x < GenerationPoint.position.x){

			distanceBetween = Random.Range(distanceBetweenMin,distanceBetweenMax);
			platformSelector = Random.Range(0,thePlatforms.Length);
			transform.position = new Vector3(transform.position.x+platformWidths[platformSelector]+distanceBetween
			+distanceBetween,transform.position.y,transform.position.z);

		
			
			Instantiate(thePlatforms[platformSelector],transform.position,transform.rotation);

		/*	GameObject newPlatform = theObjectPool.GetPooledObject();
			
			newPlatform.transform.position = transform.position;
			newPlatform.transform.rotation = transform.rotation;
			newPlatform.SetActive(true); */


		}

	}
}

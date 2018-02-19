using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour {

	// Use this for initialization
	public GameObject pooledObject;
	public int pooledAmount;
	List<GameObject> pooledObjects;

	
	void Start () {
		pooledObjects = new List<GameObject>();
		for (int i = 0; i < pooledAmount; i++){
			GameObject objGame = (GameObject)Instantiate(pooledObject);
			objGame.SetActive(false);
			pooledObjects. Add(objGame);
		}
		
	}
	
	// Update is called once per frame
	 
	 //Looking for a game oject
	 //get a pooled object we need
	 public GameObject GetPooledObject(){
		 //pull not active object
		 for (int i=0; i < pooledObjects.Count; i++){
			 if(!pooledObjects[i].activeInHierarchy){//not active within seen hierarchy
				return pooledObjects[i];
			 } 
		
		 }
		GameObject objGame = (GameObject)Instantiate(pooledObject);
		objGame.SetActive(false);
		pooledObjects. Add(objGame);
		return objGame;
			 
	 }
	  
}

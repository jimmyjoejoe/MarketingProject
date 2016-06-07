using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {
	
	public GameObject Player;
	public Transform spawnPoint;
	
	void Start () {
		
	}
	
	
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		
		other.transform.position = spawnPoint.transform.position; 
	}
}﻿
﻿using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
	
	public float paddleSpeed = 1f;
	
	
	private Vector3 playerPos = new Vector3 (0, -58f, 0);
	
	void Update () 
	{
		float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
		playerPos = new Vector3 (Mathf.Clamp (xPos, -149.5f, 148.5f), -58f, 0f);
		transform.position = playerPos;
		
	}
}
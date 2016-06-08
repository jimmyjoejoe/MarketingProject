using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
	
	public float paddleSpeed = 1f;
	
	
	private Vector3 playerPos = new Vector3 (0, -58f, 0);
	
	void Update () 
	{
		float xPos = transform.position.x + (Input.acceleration.x * paddleSpeed);
		playerPos = new Vector3 (Mathf.Clamp (xPos, -145f, 145f), -58f, 0f);
		transform.position = playerPos;
		
	}
}
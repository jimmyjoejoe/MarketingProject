using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {

	public GameObject Brick;
	
	void OnTriggerEnter2D (Collider2D other)
	{
		Destroy(Brick);
	}
}
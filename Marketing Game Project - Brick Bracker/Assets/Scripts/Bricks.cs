using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {

	public GameObject game;
	
	void OnCollision2DEnter (Collision2D other)
	{
		GM.instance.DestroyBrick();
		Destroy(game);
	}
}
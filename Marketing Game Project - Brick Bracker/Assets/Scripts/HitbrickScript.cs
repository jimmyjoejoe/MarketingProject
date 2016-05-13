using UnityEngine;
using System.Collections;

public class HitbrickScript : MonoBehaviour {
	public bool hitbrick;
	
	void OnCollision2DEnter (Collision2D other) {

		hitbrick = true;

	}
}

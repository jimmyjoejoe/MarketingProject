using UnityEngine;
using System.Collections;

public class TimedDestroy : MonoBehaviour {
	
	public float destroyTime = 1f;
	public GameObject game;
	
	// Use this for initialization
	void Start () {
		
		Destroy (game, destroyTime);
		
	}
	
}
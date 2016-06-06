using UnityEngine;
using System.Collections;

public class HitbrickScript : MonoBehaviour {
	public bool Brick;
	public GameObject[] ball;
	public GameObject Brickgame;
	private Animator Brickanim;

	void Start () {

		Brickanim = GetComponent <Animator> ();
		ball = GameObject.FindGameObjectsWithTag("Ball");
	}
	
	IEnumerator OnTriggerEnter2D (Collider2D other) {
		Brick = true;
		Brickanim.SetBool ("Brick",true);
		yield return new WaitForSeconds(1);
		Destroy (Brickgame);

	}
}

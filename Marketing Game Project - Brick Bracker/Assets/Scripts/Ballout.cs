using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ballout : MonoBehaviour {

	public int lives;
	public GameObject Ball;
	public Text LivesText;

	void Start (){
		lives = 3;
		Livescount ();
	}

	void OnTriggerEnter2D (Collider2D other){

		if (other.tag == "Ball") {
			lives = lives - 1;
			Livescount ();
		}

	}
	void Livescount (){
		LivesText.text = "lives: " + lives.ToString ();
}
}

using UnityEngine;
using System.Collections;

public class NewHitBrick : MonoBehaviour {

	private Animator BrickAnim;
	public Sprite Red;
	public Sprite Orange;
	public Sprite Yellow;
	public Sprite Green;
	public Sprite Blue;
	public Sprite Purple;

	public int numberOfBricks;
	public GameObject endingScreen;
	public GameObject lastLevelEndingScreen;


	// Use this for initialization
	void Start () {
	}
	

	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.tag == "Purple") {
			other.gameObject.GetComponent <SpriteRenderer>().sprite = Blue;
			other.gameObject.tag = "Blue";
		}

		else if (other.gameObject.tag == "Blue") {
			other.gameObject.GetComponent <SpriteRenderer>().sprite = Green;
			other.gameObject.tag = "Green";
		}

		else if (other.gameObject.tag == "Green") {
			other.gameObject.GetComponent <SpriteRenderer>().sprite = Yellow;
			other.gameObject.tag = "Yellow";
		}

		else if (other.gameObject.tag == "Yellow") {
			other.gameObject.GetComponent <SpriteRenderer>().sprite = Orange;
			other.gameObject.tag = "Orange";
		}

		else if (other.gameObject.tag == "Orange") {
			other.gameObject.GetComponent <SpriteRenderer>().sprite = Red;
			other.gameObject.tag = "Red";
		}

		else if (other.gameObject.tag == "Red") {
			BrickAnim = other.gameObject.GetComponent <Animator> ();
			BrickAnim.SetBool ("Brick",false);
			Destroy (other.gameObject);		
			numberOfBricks--;
		}

		//check to see if level is over
		if (numberOfBricks == 0 && Application.loadedLevel != 2) {
			endingScreen.SetActive (true);
		} 
		else if(Application.loadedLevel == 2){ 
			lastLevelEndingScreen.SetActive(true);		
		}
	}

	public void loadLevelTwo(){
		Application.LoadLevel(1);
	}

	public void loadLevelThree(){
		Application.LoadLevel (2);
	}
}

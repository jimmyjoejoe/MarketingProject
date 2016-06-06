using UnityEngine;
using System.Collections;

public class NewHitBrick : MonoBehaviour {

	private Animator BrickAnim;
	public GameObject Red;
	public GameObject Orange;
	public GameObject Yellow;
	public GameObject Green;
	public GameObject Blue;
	public GameObject Purple;


	// Use this for initialization
	void Start () {
	}
	

	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.tag == "Purple") {
			Destroy (other.gameObject);
			Instantiate (Blue,transform.position,transform.rotation);
					}

		if (other.gameObject.tag == "Red") {
			BrickAnim = other.gameObject.GetComponent <Animator> ();
			BrickAnim.SetBool ("Brick",true);
			Destroy (other.gameObject);		
		}

	}
}

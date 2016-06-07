using UnityEngine;
using System.Collections;

public class ConstantSpeed : MonoBehaviour {

	public int speed;

	void Start () {
	
		GetComponent<ConstantSpeed> ();

	}

	void Update (){

		GetComponent<Rigidbody2D>().velocity =  speed * (GetComponent<Rigidbody2D>().velocity.normalized);
	}
	
}
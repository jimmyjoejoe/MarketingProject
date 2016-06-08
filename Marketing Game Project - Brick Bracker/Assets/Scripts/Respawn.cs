using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
	public GameObject prefab;

	
	void OnTriggerEnter2D (Collider2D other){

		Destroy (prefab);

			Instantiate(prefab, new Vector2(0,-49), Quaternion.identity);
	}
}
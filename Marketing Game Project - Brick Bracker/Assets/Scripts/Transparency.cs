using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Transparency : MonoBehaviour {

	public float alphaValue;

	Image image;
	void Start() {
		image = GetComponent<Image>();
		
		Color c = image.color;
		c.a = alphaValue;
		image.color = c;
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	void Awake() {
		Invoke ("DeleteSelf", 10f);
	}

	public void ChangeColor(float r, float g, float b) {
		Material material = gameObject.GetComponent<Renderer> ().material;
		Color color = new Color (r,g,b);

		material.color = color;
	}

	void DeleteSelf() {
		GameObject.Destroy (gameObject);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour {

	public List<Light> lights;
	public bool isLight = true;

	// Use this for initialization
	void Start () {
		lights.Clear ();

		GameObject[] lightObjects = GameObject.FindGameObjectsWithTag("Light");

		foreach(GameObject lightObject in lightObjects) {
			Light l = lightObject.GetComponent<Light> ();
			lights.Add (l);
		}

//		for (int i = 0; i < lightObjects.Length; i++) {
//			Light l = lightObjects [i].GetComponent<Light> ();
//			lights.Add (l);
//		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.L)) {
			isLight = !isLight;
		}

		lights.ForEach(TurnLight);
	}

	void TurnLight(Light light) {
		light.enabled = isLight;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraPosition : MonoBehaviour {

	public Vector3 pos1;
	public Vector3 pos2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("1")){
			iTween.MoveTo (gameObject, pos1, 3f);
		}
		if(Input.GetKeyDown("2")){
			iTween.MoveTo (gameObject, pos2, 3f);
		}


		
	}
}

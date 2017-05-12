using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBalls : MonoBehaviour {

	public GameObject prefab;
	public Vector3 spawnVector;
	public int kugelNum=1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			InstantiateBall ();
		}
	}

	public void InstantiateBall() {

		GameObject obj = Instantiate (prefab, spawnVector, Quaternion.identity,gameObject.transform);

		obj.GetComponent<Ball>().ChangeColor(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
		kugelNum++;
	}
}

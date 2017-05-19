using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowKugelNum : MonoBehaviour {

	private int kugelNum;
	public Text kugelInfo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// GameObject[] objs = GameObject.FindGameObjectsWithTag ("Kugel");

		kugelNum = gameObject.GetComponent<InstantiateBalls> ().kugelNum;
		kugelInfo.text = kugelNum.ToString();
	}
}

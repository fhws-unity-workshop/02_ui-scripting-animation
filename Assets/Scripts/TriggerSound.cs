using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour {

	AudioSource audioPlayer;

	public AudioClip[] clips;


	// Use this for initialization
	void Start () {

		audioPlayer = gameObject.GetComponent<AudioSource> ();

		TriggerFxSound (0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TriggerFxSound(int clipNum){
		audioPlayer.clip = clips [clipNum];
		audioPlayer.Play ();
	}
}

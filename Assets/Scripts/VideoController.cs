using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour {

	private VideoPlayer vplayer;
	public VideoClip[] videos;

	// Use this for initialization
	void Start () {
		vplayer.clip = videos [0];
		vplayer = gameObject.GetComponent<VideoPlayer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A) && vplayer.isPlaying) {
			vplayer.Pause();
		} else if (Input.GetKeyDown (KeyCode.A) && vplayer.isPlaying == false) {
			vplayer.Play();
		}
	}
}

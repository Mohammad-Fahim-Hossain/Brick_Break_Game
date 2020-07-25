using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer Instance=null ;

	void Awake(){

		if (Instance != null) {
			Destroy (gameObject);		
		} else {
			GameObject.DontDestroyOnLoad (this.gameObject);
		}
	}


	// Use this for initialization


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

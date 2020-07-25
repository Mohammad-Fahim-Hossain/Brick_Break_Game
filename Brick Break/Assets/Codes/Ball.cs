  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private PaddleController paddle;
	private Vector3 ballpostition;
	private bool started=false;
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<PaddleController> ();
		ballpostition = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!started) {
			this.transform.position = ballpostition + paddle.transform.position;
		}
		if (Input.GetMouseButtonDown (0)) {
			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (2f, 15f);
			started = true;

		}

		}
	void OnCollisionEnter2D(Collision2D collision){
		
		Vector2 force=new Vector2(Random.Range(-1f,1f),Random.Range(1f,4f));

		if (started) {
			this.GetComponent<AudioSource> ().Play ();
			this.GetComponent<Rigidbody2D>().velocity+=force;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

	public bool AutoPlay=false;

	 Ball ball;


	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!AutoPlay) {
			MouseController ();
		}
		else{
			AutoPlayMode();
		}
	}
	void AutoPlayMode(){
		Vector3 PaddlePosition = new Vector3 (this.transform.position.x,this.transform.position.y, 0f);
		Vector3 BallPos = ball.transform.position;
		PaddlePosition.x = Mathf.Clamp (BallPos.x, 0.53f, 12.85f);
		this.transform.position = PaddlePosition;
	
	}

	void MouseController(){
		Vector3 PaddlePosition = new Vector3 (this.transform.position.x,this.transform.position.y, 0f);
		float MousePosition = Input.mousePosition.x / Screen.width * 14;
		PaddlePosition.x = Mathf.Clamp (MousePosition, 0.97f, 12.41f);
		this.transform.position = PaddlePosition;


	}
}


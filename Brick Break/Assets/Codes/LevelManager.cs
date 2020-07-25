using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {


	public void LevelManage(string Level){
		Brick.BrickBreakable=0;
		Application.LoadLevel (Level);

	}
	public void Quit(){
		Application.Quit ();
	}
	public void NextLevel(){
		Brick.BrickBreakable = 0;
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	public void BrickDestroyed(){
		if (Brick.BrickBreakable <= 0) {
			NextLevel ();
		}
	}


}

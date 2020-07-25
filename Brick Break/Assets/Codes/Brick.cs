using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	public AudioClip creak;
	private LevelManager levelmanage;
	public Sprite[] spriteSheet; 
	public static int BrickBreakable = 0;
	bool isBrakeable;
	public GameObject show;
	private int hits;
	 
	// Use this for initialization
	void Start () {
		isBrakeable = (this.tag == "Breakable");
		if (isBrakeable) {
			BrickBreakable++;

		}
		hits = 0;
		levelmanage = GameObject.FindObjectOfType<LevelManager> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnCollisionEnter2D(Collision2D coll){
		AudioSource.PlayClipAtPoint (creak, transform.position,1.0f);
		if (isBrakeable) {
			HandleHits ();
		}
	}
	void HandleHits(){
		hits++;


		GameObject snow=Instantiate(show,gameObject.transform.position,Quaternion.identity);
		snow.GetComponent<ParticleSystem> ().startColor = gameObject.GetComponent<SpriteRenderer> ().color;
		int Maxhits = spriteSheet.Length + 1;
		if (hits >= Maxhits) {
			BrickBreakable--;
			levelmanage.BrickDestroyed ();
			Destroy (gameObject);		
		} else {
			SpritesRander ();
		}
	
	
	
	}
	void SpritesRander(){
		int SpritesIndex = hits - 1;

		if(spriteSheet[SpritesIndex])
		{
			this.GetComponent<SpriteRenderer> ().sprite = spriteSheet [SpritesIndex];
		}

	}
	public void SimulateLevel(){
	
		levelmanage.NextLevel ();
	
	}
}

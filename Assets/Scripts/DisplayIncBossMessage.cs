using UnityEngine;
using System.Collections;

public class DisplayIncBossMessage : MonoBehaviour {
	public GUISkin gSkin;
	public bool display=false;

	void OnGUI(){
		if (display) 
		{
			GUI.skin = gSkin;
			GUI.Label (new Rect (Screen.width/2-100, Screen.height/2-150, 300, 200), "Epic Boss Battle\nIncoming!!1");
			//GUI.contentColor = Color.red;
			//GUI.Label (new Rect (Screen.width/2+50, Screen.height/2-50, 300, 200), "Literally!");
			
			//GUI.Label (new Rect (10, 10, 100, 30), "We don't see things\nas they are, we see\nthem as we are.");
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		display = true;
		}

}
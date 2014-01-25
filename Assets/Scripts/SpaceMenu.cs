using UnityEngine;
using System.Collections;

public class SpaceMenu : MonoBehaviour {
	public int level;
	void Update(){
		if (Input.GetKeyDown("space")){
			Application.LoadLevel(level);
		}
		
	}
}
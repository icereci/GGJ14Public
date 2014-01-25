using UnityEngine;
using System.Collections;

public class MenuCaller : MonoBehaviour {


	void LoadNextLevel()
	{
		Application.LoadLevel(1);
	}
	
	void OnTriggerEnter2D(Collider2D other){
			Invoke("LoadNextLevel",2f);
			return;
		}
}

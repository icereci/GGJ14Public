using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	void LoadNextLevel()
	{
		Application.LoadLevel(4);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			audio.Play();
			Invoke("LoadNextLevel",0.2f	);
			return;
		}

		if(other.gameObject.transform.parent){
			Destroy (other.gameObject.transform.parent.gameObject);
		}else{
			Destroy (other.gameObject);
		}
	}
}

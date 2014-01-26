using UnityEngine;
using System.Collections;

public class MenuCaller : MonoBehaviour {


	//public Renderer []texts=new Renderer[4];

	void LoadNextLevel()
	{
		Application.LoadLevel(1);
	}
	
	void OnTriggerEnter2D(Collider2D other){

		GetComponent<DisplayMessage> ().display = true;

		//Renderer[] texts = textObject.GetComponentsInChildren<MeshRenderer>();

		//foreach (MeshRenderer item in texts) {
			//item.GetComponent<MeshRenderer>().enabled=true;
			
	

			//Debug.Log("item ");
		//		}

			Invoke("LoadNextLevel",5f);
			return;
		}
}

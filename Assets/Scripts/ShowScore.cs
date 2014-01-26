using UnityEngine;
using System.Collections;


public class ShowScore : MonoBehaviour {

	void Start()
	{

	}

	
	public float playerScore = 0 ;
	
	// Update is called once per frame
	void Update () {
		playerScore += Time.deltaTime ;
		GetComponent<TextMesh>().text = "Score:"+ (int)(playerScore*100);
	
		
	}
	void OnDisable(){
		PlayerPrefs.SetInt ("Score", (int)(playerScore * 100));
	}
}

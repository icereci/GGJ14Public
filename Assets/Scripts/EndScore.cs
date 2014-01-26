using UnityEngine;
using System.Collections;

public class EndScore : MonoBehaviour {
	int score;
	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
			GetComponent<TextMesh>().text = "Score: "+ score;
	}
	
}

using UnityEngine;
using System.Collections;

public class DelayedPlay : MonoBehaviour {

	bool play = false;
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > 2 && !play) {
						audio.Play ();
			play=true;
				}
	}
}

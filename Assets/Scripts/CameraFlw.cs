using UnityEngine;
using System.Collections;

public class CameraFlw : MonoBehaviour {

	public Transform player;


	// Update is called once per frame
	void Update () {
		if(player)
			transform.position = new Vector3 (player.position.x + 6, 5, -10);
	}
}

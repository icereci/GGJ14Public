using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj ;
	public float spawnMin = 1f ;
	public float spawnMax = 2f ;

	// Use this for initialization
	void Start () {
		Spawn ();
	}

	void Spawn () {
		Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
//		if (obj [0].tag == "Bird") 
//		{
//			obj [0].rigidbody2D.AddForce(Vector2.right*0.2f);
//			Debug.Log("Birdie");
//		}
			Invoke ( "Spawn", Random.Range ( spawnMin, spawnMax ));
	}
}

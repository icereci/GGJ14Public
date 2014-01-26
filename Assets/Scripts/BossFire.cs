using UnityEngine;
using System.Collections;

public class BossFire : MonoBehaviour {
	
	public GameObject[] obj ;
	public float spawnMin = 3f ;
	public float spawnMax = 7f ;
	public bool canShoot;
	public int shootCount=0;
	public GameObject Boss;

	public Sprite sp1;
	public Sprite sp2;
	public Sprite sp3;

	SpriteRenderer sr;
	// Use this for initialization

	void CanShoot(){
		canShoot = true;
		Spawn ();
		}


	void Start(){
		Invoke ("CanShoot", 8f);
		sr = Boss.GetComponent<SpriteRenderer>();
		}

	
	void Spawn () {
		Debug.Log("Spawn");

		if (shootCount == 1) {
			sr.sprite = sp1;

				}
		else if (shootCount == 2) {
			sr.sprite = sp2;
			
		}
		else if (shootCount == 3) {
			sr.sprite = sp3;
			
		}
		else if (shootCount == 4) {
			Application.LoadLevel(1);
		}

		if (canShoot) {
			shootCount++;
						Instantiate (obj [Random.Range (0, obj.GetLength (0))], transform.position, Quaternion.identity);

						//obj[0].rigidbody2D.AddTorque(-1);
						obj [0].rigidbody2D.AddForce(new Vector2(-1f,-0.3f)*0.2f);

						Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
				}
	}
}

using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	public GameObject gun;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject newBullet = Instantiate (bullet, transform.position, Quaternion.identity) as GameObject;
			newBullet.GetComponent<Rigidbody> ().velocity = gun.transform.forward * 50;
		}
	}
}

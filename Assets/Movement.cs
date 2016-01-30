using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movement : MonoBehaviour {

	int speed = 10;

	public List<GameObject> rails; 
	public GameObject railObj;

	void Start () {
	
	}
	
	void Update () {
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
		if (Vector3.Distance (transform.position, rails[0].transform.position) > 50) {
			GameObject newRail = Instantiate (railObj, rails [3].transform.position + Vector3.forward * 33.7f, rails[0].transform.rotation) as GameObject; 
			rails.Add(newRail);
			Destroy (rails [0]);
			rails.RemoveAt (0);
		}
	}
}

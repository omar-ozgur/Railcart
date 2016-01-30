using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movement : MonoBehaviour {

	public int speed = 10;

	public List<GameObject> rails; 
	public GameObject railObj;

	public GameObject reticle;

	void Start () {
		Cursor.visible = false;
	}
	
	void Update () {
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
		if (Vector3.Distance (transform.position, rails[0].transform.position) > 50) {
			GameObject newRail = Instantiate (railObj, rails [3].transform.position + Vector3.forward * 33.7f, rails[0].transform.rotation) as GameObject; 
			rails.Add(newRail);
			Destroy (rails [0]);
			rails.RemoveAt (0);
		}

		if (Input.GetKey (KeyCode.R)) {
			Application.LoadLevel (Application.loadedLevel);
		}

		var mousePos = Input.mousePosition;
		mousePos.x -= Screen.width/2;
		mousePos.y -= Screen.height/2;
		mousePos.x /= 300;
		mousePos.y /= 300;
		mousePos.x -= 9.5f;
		mousePos.y += 3.875f;
		reticle.transform.localPosition = new Vector3 (mousePos.x, mousePos.y, transform.position.z + 1.2f);
	}
}

using UnityEngine;
using System.Collections;

public class GunLook : MonoBehaviour {

	private Camera cam;

	void Start () {
		cam = Camera.main;
	}

	void Update () {
		RaycastHit hit;
		Ray ray = cam.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			this.transform.LookAt(hit.point);
		}
	}
}

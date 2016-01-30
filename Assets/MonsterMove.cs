using UnityEngine;
using System.Collections;

public class MonsterMove : MonoBehaviour {

	public float speed = 5f;
	public float stopDistance = 1f;
	public float rotationSpeed = 1f;

	private Transform player;
	Quaternion lookRotation;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update () {
		if (Vector3.Distance (this.transform.position, player.position) > stopDistance) {
			this.transform.position = Vector3.Lerp(this.transform.position, player.position, speed * Time.deltaTime);
		}
		lookRotation = Quaternion.LookRotation (new Vector3 (this.transform.position.x, 0, this.transform.position.z) - new Vector3 (player.position.x, 0, player.position.z));
		this.transform.rotation = Quaternion.Lerp(this.transform.rotation, lookRotation, rotationSpeed);
	}
}

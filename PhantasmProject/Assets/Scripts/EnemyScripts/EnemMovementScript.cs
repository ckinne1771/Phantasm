using UnityEngine;
using System.Collections;

public class EnemMovementScript : MonoBehaviour {
	public float speed = 5.0f;
	// Update is called once per frame
	void Update () {
		Vector3 playerPos = GameObject.Find ("Player").transform.position;

		Quaternion rotation = Quaternion.LookRotation (playerPos - transform.position, transform.TransformDirection (Vector3.up));
		transform.rotation = Quaternion.Slerp (transform.rotation, new Quaternion(0, 0, rotation.z, rotation.w), speed*Time.deltaTime);
		//Debug.Log (transform.rotation.ToString ());

		transform.position = Vector3.MoveTowards (transform.position, playerPos, speed * Time.deltaTime);
	

	}
}

using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 10.0f;

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.A)) {
			transform.position = new Vector3((transform.position.x - 1.0f * speed *Time.deltaTime), transform.position.y, transform.position.z);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.position = new Vector3((transform.position.x + 1.0f * speed *Time.deltaTime), transform.position.y, transform.position.z);
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position = new Vector3(transform.position.x , (transform.position.y - 1.0f * speed *Time.deltaTime), transform.position.z);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.position = new Vector3(transform.position.x , (transform.position.y + 1.0f * speed *Time.deltaTime), transform.position.z);
		}

	}
}

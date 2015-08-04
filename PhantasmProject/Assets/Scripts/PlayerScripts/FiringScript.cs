using UnityEngine;
using System.Collections;

public class FiringScript : MonoBehaviour {
	public GameObject bulletPrefab;
	GameObject Clone;
	  

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.Mouse0)) {
			Clone = (Instantiate (bulletPrefab, transform.position, transform.rotation)) as GameObject;
		}
	}
}
using UnityEngine;
using System.Collections;

public class EnemyCollisionScript : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		Debug.Log ("collision");
		if (other.gameObject.tag == "bullet") {
			Destroy (gameObject);
		}
	}
}

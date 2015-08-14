using UnityEngine;
using System.Collections;

public class EnemyCollisionScript : MonoBehaviour {

	// Use this for initialization

	public static bool scoreChange = false; 
	
	// Update is called once per frame
	void Update () {
	
	}
 
	void OnCollisionEnter2D (Collision2D other)
	{
		Debug.Log ("collision");
		if (other.gameObject.tag == "bullet") {
			Destroy (gameObject);
			Destroy (other.gameObject);
			scoreChange=true;

			//GUIScript.IncreaseScore ();
		}

		if (other.gameObject.tag == "Player") {
			ChangeSceneScript.ChangeScene();
		}
	}
}

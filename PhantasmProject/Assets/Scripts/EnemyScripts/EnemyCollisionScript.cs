using UnityEngine;
using System.Collections;

public class EnemyCollisionScript : MonoBehaviour {

	// Use this for initialization

	public static bool scoreChange = false; 
	public GameObject wreckedPrefab;


	// Update is called once per frame
	void Update () {
	
	}
 
	void OnCollisionEnter2D (Collision2D other)
	{
		Debug.Log ("collision");
		if (other.gameObject.tag == "bullet") {
			Destroy (other.gameObject);
			GameObject wrecked = (GameObject)Instantiate(wreckedPrefab, transform.position, transform.rotation);

		//	foreach (Rigidbody2D body in wrecked.GetComponentsInChildren<Rigidbody2D>()) {
				//gameObject.transform.position+= transform.forward*speed*Time.deltaTime;
			//}

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

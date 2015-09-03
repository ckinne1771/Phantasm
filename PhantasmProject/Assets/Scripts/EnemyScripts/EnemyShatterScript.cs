using UnityEngine;
using System.Collections;

public class EnemyShatterScript : MonoBehaviour {

	public float speed = 3.0f;
	// Use this for initialization
	 void Start()
	{
		Vector3 randomdirection = new Vector3 (Random.Range (0.0f, 359.9f), Random.Range (0.0f, 359.9f), Random.Range (0.0f, 359.9f));
		transform.LookAt (randomdirection);
	}

	void Update(){
		transform.position += transform.forward * speed * Time.deltaTime;
	}



}

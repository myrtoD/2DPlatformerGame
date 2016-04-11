using UnityEngine;
using System.Collections;

public class bulletMover : MonoBehaviour {
	
	public float speed = 10;

	// Use this for initialization
	void Start () {

	}

	/*void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.name == "Enemy") {
			Destroy (gameObject);
		}
	}*/

	// Update is called once per frame
	void Update () {
		transform.position = transform.position + Vector3.right * speed * Time.deltaTime ;

	}
}
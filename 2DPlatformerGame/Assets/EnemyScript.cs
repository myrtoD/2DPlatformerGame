using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	private Transform startPoint, endPoint;
	public float percentage;
	public float speed = 1;
	private int direction;
	public GameObject Explosion;

	void Start () {
		
		startPoint = GameObject.Find ("startPoint").transform;
		endPoint = GameObject.Find ("endPoint").transform;
		direction = 1;
		//Destroy (gameObject, gameObject.GetComponent<ParticleSystem> ().duration);
	}

	void Update () {
		
		transform.position = Vector3.Lerp (startPoint.position, endPoint.position, percentage);

		speed = Mathf.Max (speed, .000001f);
		percentage += Time.deltaTime / speed * direction;


		if ((percentage > 1) || (percentage < 0)) {
			direction = -direction;
			percentage = Mathf.Clamp (percentage, 0, 1);
		}
	}

	void OnTriggerEnter2D (Collider2D otherObject) {
		if (otherObject.gameObject.tag == "Bullet") {
			Destroy (otherObject.gameObject);
			Destroy (gameObject);
			Instantiate (Explosion, transform.position, transform.rotation);
		}
	}
	/*void OnCollisionEnter (Collision other) {
		if (other.gameObject.name == "Bullet") {
			Destroy (gameObject);
		}
		}*/
}
using UnityEngine;
using System.Collections;

public class enemyScript4 : MonoBehaviour {

	private Transform startPoint4, endPoint4;
	public float percentage;
	public float speed = 1;
	private int direction;
	public GameObject Explosion;

	void Start () {

		startPoint4 = GameObject.Find ("startPoint4").transform;
		endPoint4 = GameObject.Find ("endPoint4").transform;
		direction = 1;
		//Destroy (gameObject, gameObject.GetComponent<ParticleSystem> ().duration);
	}

	void Update () {

		transform.position = Vector3.Lerp (startPoint4.position, endPoint4.position, percentage);

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
}
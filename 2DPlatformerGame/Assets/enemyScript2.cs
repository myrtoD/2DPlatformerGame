using UnityEngine;
using System.Collections;

public class enemyScript2 : MonoBehaviour {

	private Transform startPoint3, endPoint3;
	public float percentage;
	public float speed = 1;
	private int direction;
	public GameObject Explosion;

	void Start () {

		startPoint3 = GameObject.Find ("startPoint3").transform;
		endPoint3 = GameObject.Find ("endPoint3").transform;
		direction = 1;
		//Destroy (gameObject, gameObject.GetComponent<ParticleSystem> ().duration);
	}

	void Update () {

		transform.position = Vector3.Lerp (startPoint3.position, endPoint3.position, percentage);

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
using UnityEngine;
using System.Collections;

public class enemyScript3 : MonoBehaviour {


	private Transform startPoint5, endPoint5;
	public float percentage;
	public float speed = 1;
	private int direction;
	public GameObject Explosion;

	void Start () {

		startPoint5 = GameObject.Find ("startPoint5").transform;
		endPoint5 = GameObject.Find ("endPoint5").transform;
		direction = 1;
		//Destroy (gameObject, gameObject.GetComponent<ParticleSystem> ().duration);
	}

	void Update () {

		transform.position = Vector3.Lerp (startPoint5.position, endPoint5.position, percentage);

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
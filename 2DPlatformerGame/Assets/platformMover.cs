using UnityEngine;
using System.Collections;

public class platformMover : MonoBehaviour {
	
	private Transform startPoint1, endPoint1;
	public float percentage;
	public float speed = 1;
	private int direction;
	public GameObject Explosion;

	void Start () {

		startPoint1 = GameObject.Find ("startPoint1").transform;
		endPoint1 = GameObject.Find ("endPoint1").transform;
		direction = 1;
	}

	void Update () {

		transform.position = Vector3.Lerp (startPoint1.position, endPoint1.position, percentage);

		speed = Mathf.Max (speed, .000001f);
		percentage += Time.deltaTime / speed * direction;


		if ((percentage > 1) || (percentage < 0)) {
			direction = -direction;
			percentage = Mathf.Clamp (percentage, 0, 1);
		}
	}
}
using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {

	private Transform startPoint2, endPoint2;
	public float percentage;
	public float speed = 1;
	private int direction;
	public GameObject Explosion;

	void Start () {

		startPoint2 = GameObject.Find ("startPoint2").transform;
		endPoint2 = GameObject.Find ("endPoint2").transform;
		direction = 1;
	}

	void Update () {

		transform.position = Vector3.Lerp (startPoint2.position, endPoint2.position, percentage);

		speed = Mathf.Max (speed, .000001f);
		percentage += Time.deltaTime / speed * direction;


		if ((percentage > 1) || (percentage < 0)) {
			direction = -direction;
			percentage = Mathf.Clamp (percentage, 0, 1);
		}
	}
}
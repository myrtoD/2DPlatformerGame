using UnityEngine;
using System.Collections;

public class explodeScript : MonoBehaviour {

	void Start () {
		
		GetComponent<Rigidbody2D>().AddForce( Random.insideUnitSphere * 1000 );

	}

}
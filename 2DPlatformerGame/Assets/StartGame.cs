﻿using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	
	void Update () {
		if (Input.GetButton ("Jump")) {
			beginGame ();
		}
	
	}

	void beginGame() {
		Application.LoadLevel (1);

	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scan: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Scanned () {
		GetComponent<AudioSource>().Play();
		//inc score
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Performs inifinite rotation
public class Rotator : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(13, 30, 45) * Time.deltaTime);
	}
}

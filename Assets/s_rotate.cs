﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_rotate : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.up, 200 * Time.deltaTime);
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Transform target;


	void Update () {
		transform.position.x = target.position.x;
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UP_ADOOP : MonoBehaviour {

	float DE_SPEED;

	// Use this for initialization
	void Start () {
		DE_SPEED = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 HAHAHA = this.transform.position;
		HAHAHA.y += DE_SPEED;
		if (HAHAHA.y >= 25f) 
		{
			DE_SPEED *= -1f;
		}
		if (HAHAHA.y <= 3f) 
		{
			DE_SPEED *= -1f;
		}

		this.transform.position = HAHAHA;
	}
}

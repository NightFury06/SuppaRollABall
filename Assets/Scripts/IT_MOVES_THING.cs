using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IT_MOVES_THING : MonoBehaviour {
	float speed;


	// Use this for initialization
	void Start () {
		speed = 0.05f;

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = this.transform.position;
		temp.x += speed;


		if (temp.x >= 0.05f) 
		{
			speed *= -1f;
		}

		if (temp.x <= -40f) 
		{
			speed *= -1f;
		}

		this.transform.position = temp;
	}
}

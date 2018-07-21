using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour {
	public bool isCollected;
    public bool hasPlayed;
    AudioSource AS;

    Vector3 direction;
	// Use this for initialization
	void Start () {
		isCollected = false;
        hasPlayed = false;
        AS = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (isCollected) {
           if(hasPlayed == false)
            {
                AS.Play();
                hasPlayed = true;
            }
			Debug.Log ("isCollected has been set to True for me!");
			Destroy (this.gameObject, 1f);
			Disappear ();
		}
	}
	void Disappear()
	{ 
		this.transform.Rotate(Vector3.up, 720 * Time.deltaTime);
		this.transform.localScale += new Vector3(.25f,.25f,.25f) * Time.deltaTime;
		this.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectcontroler : MonoBehaviour {

	public void level1()
	{
		SceneManager.LoadScene("hedgehog thing");
	}
	public void level3()
	{
		SceneManager.LoadScene("level 3");
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

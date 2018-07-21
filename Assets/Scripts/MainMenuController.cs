using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {
    
    public void NewGame()
    {
        SceneManager.LoadScene("hedgehog thing");
    }
	public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
	public void LevelSelect()
	{
		SceneManager.LoadScene("Level Select");
	}

	public void level1()
	{
		SceneManager.LoadScene("level 2");
	}
	public void level3()
	{
		SceneManager.LoadScene("level 3");
	}

	public void back()
	{
		SceneManager.LoadScene("menu");
	}




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

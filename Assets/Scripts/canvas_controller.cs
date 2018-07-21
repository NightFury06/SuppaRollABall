using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvas_controller : MonoBehaviour {
    public GameObject triesText;
	public GameObject scoreText;
	int score;
    int tries;
	// Use this for initialization
	void Start () {
		score = 0;
        tries = 3;
		scoreText.GetComponent<Text>().text = "Score: 0";
        triesText.GetComponent<Text>().text = "Tries: 3";


	}
	
	// Update is called once per frame
	void Update()
	{
		if (tries <= 0) {
			SceneManager.LoadScene("menu");
		}
	}

		
public void IncreaseScore(int amount)
{
	//Increase score by amount
		score += amount;
	// Set the text method of scoreText's Text component
			scoreText.GetComponent<Text>().text = "Score: " + score.ToString();
		if (score >= 1000)
		{
			score -= 1000;
				tries += 1;
			triesText.GetComponent<Text>().text = "Tries: " + tries.ToString();
		}
	}
    public void LoseTries()
    {
        tries -= 1;
        triesText.GetComponent<Text>().text = "Tries: " + tries.ToString();
    }


}
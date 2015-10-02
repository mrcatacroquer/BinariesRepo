using UnityEngine;
using System.Collections;

public class GameControlScript : MonoBehaviour 
{
	public static GameControlScript current;	
	public GUIText scoreText;					
	public GameObject gameOvertext;				

	int score = 0;								
	bool isGameOver = false;					

	void Awake()
	{
		if (current == null)
			current = this;
		else if(current != this)
			Destroy (gameObject);
	}

	void Update()
	{
		if (isGameOver && Input.anyKey) 
			Application.LoadLevel(Application.loadedLevel);
	}

	public void BirdScored()
	{
		if (isGameOver)	return;
		score++;
		scoreText.text = "Score: " + score;
	}

	public void BirdDied()
	{
		gameOvertext.SetActive (true);
		isGameOver = true;
	}
}

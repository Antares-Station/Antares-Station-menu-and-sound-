using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour 
{
	public GameObject PauseBackground;

	private bool paused = false;

	void Start()
	{
		PauseBackground.SetActive (false);
	}

	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			paused = !paused;
		} 

		if(paused)
		{
			PauseBackground.SetActive (true);
			Time.timeScale = 0;
		}

		if(!paused)
		{
			PauseBackground.SetActive (false);
			Time.timeScale = 1;
		}
	}
}

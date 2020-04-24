using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuClick : MonoBehaviour {

	// Use this for initialization
	public void isGame()
	{		
		Application.LoadLevel("Level 1");
	}

	public void isOptions()
	{
		Application.LoadLevel("Options");
	}
	public void isQuit()
	{
		Application.Quit();
	}
}

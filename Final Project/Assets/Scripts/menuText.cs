using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuText : MonoBehaviour {

    public Text titleText;
    public Text playText;
    public Text optionsText;
    public Text quitText;

    public bool isGame;
	public bool isOptions;
	public bool isQuit;

	// Use this for initialization
	void Start () {
		titleText.text = "Main Menu";
		playText.text = "Play Game";
		optionsText.text = "Settings";
		quitText.text = "Quit Game";
	}

	// Update is called once per frame
	void OnMouseUp()
	{

		if (isGame)
		{
			Application.LoadLevel("Level 1");
		}

		if (isOptions)
		{
			Application.LoadLevel("Options");
		}

		if (isQuit)
		{
			Application.Quit();
		}
	}
}

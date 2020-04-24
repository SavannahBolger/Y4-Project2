using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuText : MonoBehaviour {

    public Text playText;
    public Text optionsText;
    public Text quitText;

    public bool isGame;
	public bool isOptions;
	public bool isQuit;

	// Use this for initialization
	void Start () {
		playText.text = "Play Game";
		optionsText.text = "Settings";
		quitText.text = "Quit Game";
	}
}

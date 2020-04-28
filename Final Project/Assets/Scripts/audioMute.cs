using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioMute : MonoBehaviour {

	AudioSource audioSource;
	// Use this for initialization
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void Mute()
	{
		audioSource.mute = !audioSource.mute;
	}
}

using Leap;
using Leap.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHand : MonoBehaviour {

    Controller controller;
	Frame frame;
	Frame previous;
	Hand hand;
    // Use this for initialization
    void Start()
    {
        controller = new Controller();
        frame = controller.Frame();
        previous = controller.Frame(1);
        if (frame.Hands.Count > 0)
        {
            List<Hand> hands = frame.Hands;
            hand = frame.Hands[0];
        }

    }

	public Hand SourceHand
	{
		set
		{
			hand = value;
		}
	}

	// Update is called once per frame
	void Update () {
		if (hand != null)
		{
			
			// Use the rotation from the live data
			var handRotation = hand.Rotation.x;
            Debug.Log("hand detect");
			// Transform the copied hand so that it's centered on the current hands position and matches it's rotation.
			//transform.Rotate(hand.Rotation.ToVector3());
		}

	}
}

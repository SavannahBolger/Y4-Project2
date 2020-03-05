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
         		var handRotationX = hand.Rotation.x;
         		var handRotationZ = hand.Rotation.z;
                    Debug.Log("hand detect");
         		// Transform the copied hand so that it's centered on the current hands position and matches it's rotation.
         		transform.Rotate(handRotationX, 0, handRotationZ);
         	}

         }

         // <summary>
         // The Leap controller.
         // </summary>
         Controller controller;

         /// <summary>
         /// The current frame captured by the Leap Motion.
         /// </summary>
         Frame CurrentFrame
         {
             get { return (IsReady) ? controller.Frame() : null; }
         }

         /// <summary>
         /// Gets the hands data captured from the Leap Motion.
         /// </summary>
         /// <value>
         /// The hands data captured from the Leap Motion.
         /// </value>
         List<Hand> Hands
         {
             get { return (CurrentFrame != null && CurrentFrame.Hands.Count > 0) ? CurrentFrame.Hands : null; }
         }

         /// <summary>
         /// Gets a value indicating whether the Leap Motion is ready.
         /// </summary>
         /// <value>
         ///   <c>true</c> if this instance is ready; otherwise, <c>false</c>.
         /// </value>
         bool IsReady
         {
             get { return (controller != null && controller.Devices.Count > 0 && controller.IsConnected); }
         }

         // <summary>
         // Awake is called when the script instance is being loaded.
         // </summary>
         void Awake()
         {
             controller = new Controller();
         }

         /// <summary>
         /// Update function called every frame.
         /// </summary>
         void Update()
         {
             Hand mainHand; // The front most hand captured by the Leap Motion Controller

             // Check if the Leap Motion Controller is ready
             if (!IsReady || Hands == null)
             {
                 return;
             }

             mainHand = CurrentFrame.Hands[0].Frontmost;

             transform.rotation = Quaternion.Euler(mainHand.Direction.Pitch, mainHand.Direction.Yaw, mainHand.PalmNormal.Roll);

              //For relative orientation
              transform.rotation *= Quaternion.Euler( mainHand.Direction.Pitch, mainHand.Direction.Yaw, mainHand.PalmNormal.Roll );

         }
    //Controller controller;
    //float HandPalmPitch;
    //float HandPalmYaw;
    //float HandPalmRoll;
    //float HandWristRot;

    //void Start()
    //{

    //}

    //void Update()
    //{
    //    controller = new Controller();
    //    Frame frame = controller.Frame();
    //    List<Hand> hands = frame.Hands;
    //    if (frame.Hands.Count > 0)
    //    {
    //        Hand fristHand = hands[0];
    //    }

    //    HandPalmPitch = hands[0].PalmNormal.Pitch;
    //    HandPalmRoll = hands[0].PalmNormal.Roll;
    //    HandPalmYaw = hands[0].PalmNormal.Yaw;

    //    HandWristRot = hands[0].WristPosition.Pitch;

    //    Debug.Log("Pitch :" + HandPalmPitch);
    //    Debug.Log("Roll :" + HandPalmRoll);
    //    Debug.Log("Yaw :" + HandPalmYaw);

    //    if(HandPalmYaw > -2f && HandPalmYaw < 3.5f)
    //    {
    //        transform.rotation *= Quaternion.Euler( HandPalmPitch, 0, HandPalmRoll);
    //    }
    //}
}

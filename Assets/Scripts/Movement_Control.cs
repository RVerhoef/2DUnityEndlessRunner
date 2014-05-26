using UnityEngine;
using System.Collections;

public class Movement_Control : MonoBehaviour {

	void Update () {
		//When the player presses up, he jumps
		if (Input.GetKeyDown ("up"))
		animation.Play ("Jump", PlayMode.StopAll);
		//When the player presses down, he slides
		if (Input.GetKeyDown ("down"))
			animation.Play ("Crouch", PlayMode.StopAll);
	}
}

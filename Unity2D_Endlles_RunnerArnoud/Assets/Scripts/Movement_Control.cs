using UnityEngine;
using System.Collections;

public class Movement_Control : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown ("up"))
		animation.Play ("Jump", PlayMode.StopAll);

		if (Input.GetKeyDown ("down"))
			animation.Play ("Crouch", PlayMode.StopAll);
	}
}

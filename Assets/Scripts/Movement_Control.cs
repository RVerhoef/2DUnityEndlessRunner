//Made by Rob
using UnityEngine;
using System.Collections;

public class Movement_Control : MonoBehaviour {

	Animator anim;

	void Start (){
		anim = GetComponent<Animator>();
	}

	void FixedUpdate () {
		//When the player presses up, the jump animation is played
		if (Input.GetKeyDown ("up"))
			anim.SetBool("Jumping", true);
		else anim.SetBool("Jumping", false);
		//When the player presses down, the slide animation is played
		if (Input.GetKeyDown ("down"))
			anim.SetBool("Sliding", true);
		else anim.SetBool("Sliding", false);
		//When the player presses the mousebutton, he attacks
		if (Input.GetMouseButtonDown (1))
		anim.SetBool ("Attacking", true);
		else anim.SetBool("Attacking", false);
		//Change the tag of the player when he uses his sword
		if (anim.GetBool("Attacking") == true)
		gameObject.tag = "Ninja_Attack";
		else gameObject.tag = "Player";
	}
}

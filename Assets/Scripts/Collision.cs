//Made by Rob
using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	Animator anim;


	void OnTriggerEnter2D(Collider2D col){

				anim = GetComponent<Animator> ();
				//when the ninja collides with an obstacle, the game ends
				if (col.gameObject.tag == ("Obstacle"))
				Application.LoadLevel("DeathScene");
		}
}

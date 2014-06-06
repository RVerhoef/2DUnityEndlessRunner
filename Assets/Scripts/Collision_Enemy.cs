//Made by Rob
using UnityEngine;
using System.Collections;

public class Collision_Enemy : MonoBehaviour {
	
	Animator anim;
	
	void OnTriggerEnter2D(Collider2D col){
		
		anim = GetComponent<Animator> ();
		//when an enemy collides with an obstacle, the timer starts
		if (col.gameObject.tag == ("Ninja_Attack"))
		StartCoroutine(DeadTime()); 
		}
	//the enemy plays its death animation and get destroyed
	IEnumerator DeadTime() {
			anim.SetBool ("DeadEnemy", true);
			yield return new WaitForSeconds(1);  
			Destroy(gameObject);
		}
	}

using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
void OnTriggerEnter2D(Collider2D col){
		//when the player collides with an obstacle, he dies.
		if (col.gameObject.tag == "Obstacle")
			Debug.Log("Dead");
		} 
}

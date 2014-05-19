using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Cube")
			Debug.Log("Dead");
		} 
}

//Made by Rob
using UnityEngine;
using System.Collections;

public class Arm_Rotator : MonoBehaviour {

	public Vector3 mouse_pos;
	public Vector3 object_pos;
	public float angle;
	
	void FixedUpdate () {    
		//Makes the arm rotate towards the mouse
		mouse_pos = Input.mousePosition;
		mouse_pos.z = 0.0f;
		object_pos = Camera.main.WorldToScreenPoint(transform.position);
		mouse_pos.x = mouse_pos.x - object_pos.x;
		mouse_pos.y = mouse_pos.y - object_pos.y;
		angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg - 270;
		Vector3 rotationVector = new Vector3 (0, 0, angle);
		transform.rotation = Quaternion.Euler(rotationVector);

	}
}

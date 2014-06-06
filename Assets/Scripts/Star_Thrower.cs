//Made by Rob
using UnityEngine;
using System.Collections;

public class Star_Thrower : MonoBehaviour {
	
	public GameObject ammo;
	public float bulletSpeed;

	void FixedUpdate () {
	//find the arm of the player and uses some of its code to shoot the star in thr right direction
		GameObject theMouse = GameObject.Find ("Arm");
		Arm_Rotator rotator = theMouse.GetComponent<Arm_Rotator>();
		//puts the star on the scene and shoots it
		if (Input.GetMouseButtonDown (0)) {
			GameObject bullet = (GameObject)Instantiate(ammo, transform.position, transform.rotation);
			bullet.transform.LookAt(rotator.mouse_pos);
			bullet.rigidbody2D.AddForce(bullet.transform.forward * bulletSpeed);
		}
	}
}

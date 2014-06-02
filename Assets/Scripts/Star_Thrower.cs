using UnityEngine;
using System.Collections;

public class Star_Thrower : MonoBehaviour {

	public Transform Star;

	//Shoots a star when the left mouse button is pressed
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Mouse2)) 
		{
			ShootStar();		
		}
		
	}

	//Puts the star into the game world
	void ShootStar()
	{
		Instantiate(Star, this.transform.position, this.transform.rotation);

	}
}

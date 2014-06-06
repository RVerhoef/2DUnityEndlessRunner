//Made by Rob
using UnityEngine;
using System.Collections;

public class Star_Control : MonoBehaviour {

	public float destroyTime;

	//Destroys the star after some time
	void Start () {

	Destroy (gameObject, destroyTime);

	}
}


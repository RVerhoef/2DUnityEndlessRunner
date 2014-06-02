using UnityEngine;
using System.Collections;

public class Star_Control : MonoBehaviour {

	public float destroyTime;
	public float speed;

	//Destroys the star after some time
	void Start () {

	Destroy (gameObject, destroyTime);

	}

	//Speed of the star
	void Update () {

	this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
	
	}
}

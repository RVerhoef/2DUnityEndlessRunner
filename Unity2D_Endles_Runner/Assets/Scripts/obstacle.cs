using UnityEngine;
using System.Collections;

public class obstacle : MonoBehaviour {
	
	public float speed;
	public float offscreen;
	public float high;
	
	
	void Update () 
	{
		transform.Translate(Vector2.right * speed);
		
		if (transform.position.x < offscreen)
		{
			Destroy (gameObject);
		}
	}
	
}

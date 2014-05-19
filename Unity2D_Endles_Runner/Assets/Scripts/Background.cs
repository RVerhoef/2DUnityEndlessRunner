using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	public float speed;
	public float offscreen;
	public float highest;
	public float lowest;
	public float spawn;


	void Update () 
	{
		transform.Translate(Vector2.right * speed);

		while (transform.position.x < offscreen)
		{
			transform.position = new Vector3(spawn,Random.Range(highest, lowest),0);
		}
	}

}

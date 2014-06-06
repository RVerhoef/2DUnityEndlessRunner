using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GUIStyle style;
	public Texture texture;

	void OnGUI(){
		GUI.skin.button = style;

		if (GUI.Button (new Rect (Screen.width/2 - 220, 140, 480, 320), texture)) {
			Application.LoadLevel("TestSceneArnoud");
		}
	}
}

using UnityEngine;
using System.Collections;

public class HowToPlay : MonoBehaviour {
	
	public GUIStyle style;
	public Texture texture;
	
	void OnGUI(){
		GUI.skin.button = style;
		
		if (GUI.Button (new Rect (Screen.width/2 - 350, 530, 480, 320), texture)) {
			Application.LoadLevel("MenuScene");
		}
	}
}

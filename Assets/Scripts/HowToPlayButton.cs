using UnityEngine;
using System.Collections;

public class HowToPlayButton : MonoBehaviour {
	
	public GUIStyle style;
	public Texture texture;
	
	void OnGUI(){
		GUI.skin.button = style;
		
		if (GUI.Button (new Rect (Screen.width/2 - 105, 310,205, 140), texture)) {
			Application.LoadLevel("HowToPlay");
		}
	}
}

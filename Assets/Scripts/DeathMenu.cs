﻿using UnityEngine;
using System.Collections;

public class DeathMenu : MonoBehaviour {
	
	public GUIStyle style;
	public Texture texture;
	
	void OnGUI(){
		GUI.skin.button = style;
		
		if (GUI.Button (new Rect (Screen.width/2 - 90, 290,320, 260), texture)) {
			Application.LoadLevel("TestSceneArnoud");
		}
	}
}

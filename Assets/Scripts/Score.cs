﻿using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	float ydir = 0f;
	public GameObject player;
	//for our GUIText object and our score
	public GUIElement gui;
	float playerScore = 0;
	
	//this function updates our guitext object
	void OnGUI(){
		gui.guiText.text = "Score: " + ((int)(playerScore * 10)).ToString ();
	}
	//this is generic function we can call to increase the score by an amount
	public void increaseScore(int amount){
		playerScore += amount;
	}
	
	// Update is called once per frame
	void Update () {
		//check that player exists and then proceed. otherwise we get an error when player dies
		if (player) {
			
			//if player has passed the x position of -1 then start moving camera forward with a randomish Y position
			if (player.transform.position.x > -1) {
				
				//update our score every tick of the clock
				playerScore += Time.deltaTime;
				
				float randy = 0f;
				randy = Random.Range (0f, 100f);
				if (randy < 20) {
					ydir = ydir + .005f;
				} else if (randy > 20 && randy < 40) {
					ydir = ydir - .005f;
				} else if (randy > 80) {
					ydir = 0f;
				}
				transform.position = new Vector3 (transform.position.x + 0.03f, transform.position.y + ydir, -10);
			}
		}
	}
}
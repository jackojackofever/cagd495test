﻿using System;
using UnityEngine;
using System.Collections;

namespace Assets.Scripts.Character
{

	class CharController : Components.ControllerBase
	{
		private static CharController _instance;
		public static CharController Instance{
			get{
				_instance = _instance ?? GameObject.FindObjectOfType<CharController> ();
				if (_instance == null) {
					Debug.LogWarning ("No CharController in scene but an object is attempted to access it");
				}
				return _instance;
			}
		}
		Components.PlayerMovement _movement;



		float playerDirection;

		void Awake(){
			_movement = gameObject.AddComponent<Components.PlayerMovement> ();

		}

		void Update(){
			GetInput ();
			_movement.MovePlayer (playerDirection);
			_movement.WallGrab ();

		}


			void GetInput() //gets input to be used in the manageInput function, subject to be removed once a input manager is implemeted
			{

				float horzInput = Input.GetAxis ("Horizontal");


			if (Mathf.Abs (horzInput) > 0.15f) {
				if (horzInput > 0) {
					playerDirection = 1f;
				}
				if (horzInput < 0) {
					playerDirection = -1f;
				}
			} else {
				playerDirection = 0f;
			}


				//if ((Input.GetKeyDown(KeyCode.Space))
					if(Input.GetButtonDown("Fire1"))
				{
				_movement.JumpPlayer(playerDirection);
				}
			
				//if (Input.GetKeyDown (KeyCode.LeftShift)) {
					if(Input.GetButtonDown("Fire2")){
				_movement.DashPlayer();
				} 





			}



}
}
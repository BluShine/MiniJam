﻿using UnityEngine;
using System.Collections;
using UnityEditor;

public class LoadingDoors : MonoBehaviour {

   Animator anim;

   public delegate void LoadingDoorStateChangedHandler();
   public LoadingDoorStateChangedHandler OnDoorsOpened;
   public LoadingDoorStateChangedHandler OnDoorsClosed;

	// Use this for initialization
	void Start () {
      anim = GetComponent<Animator>();
      anim.Play("CloseDoors", 0, 1);
	}
	
	public void OpenDoors () 
   {
      anim.Play("OpenDoors");
	}
   public void CloseDoors()
   {
      anim.Play("CloseDoors");
   }

   public void DoorsOpened()
   {
      if (OnDoorsOpened != null)
         OnDoorsOpened();
   }

   public void DoorsClosed()
   {
      if (OnDoorsClosed != null)
         OnDoorsClosed();
   }
}

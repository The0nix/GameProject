﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Restarter : MonoBehaviour {

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void RestartGame ()
    {
        CollisionCheck.ColliderIsOn = true;
        Application.LoadLevel(1);
    }
}

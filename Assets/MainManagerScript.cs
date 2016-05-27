using UnityEngine;
using System.Collections;

public class MainManagerScript : MonoBehaviour {

    public AudioSource PlayOST;

	// Use this for initialization
	void Start () {
        PlayOST.time = 130;
        PlayOST.Play();
        SaveLoad.Load();
        CollisionCheck.ColliderIsOn = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

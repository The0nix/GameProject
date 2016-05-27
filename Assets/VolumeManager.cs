using UnityEngine;
using System.Collections;

public class VolumeManager : MonoBehaviour {

    public AudioSource Boom;
    public AudioSource PlayOST;
    public AudioSource PauseOST;
    public float BoomVolume;
    public float PlayOSTVolume;
    public float PauseOSTVolume;

    // Use this for initialization
    void Start () {
        Boom.volume = BoomVolume;
        PlayOST.volume = PlayOSTVolume;
        PauseOST.volume = PauseOSTVolume;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

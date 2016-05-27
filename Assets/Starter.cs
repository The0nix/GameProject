using UnityEngine;
using System.Collections;

public class Starter : MonoBehaviour {

    public AudioSource PlayOST;
    private AsyncOperation async;
    private bool loaded = false;

    // Use this for initialization
    void Start () {
        loaded = true;
        StartCoroutine("LoadLevel");
	}
	
	// Update is called once per frame
	void Update () {
        if (!loaded) {
            loaded = true;
            StartCoroutine("LoadLevel");
        }
	}

    public void StartGame() {
        async.allowSceneActivation = true;
        //Application.LoadLevel(1);
    }

    IEnumerator LoadLevel()
    {
        print("Loading started");
        async = Application.LoadLevelAsync(1);
        async.allowSceneActivation = false;
        print("Loading completed");
        yield return async;
    }
}

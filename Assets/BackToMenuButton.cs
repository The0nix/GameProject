using UnityEngine;
using System.Collections;

public class BackToMenuButton : MonoBehaviour {

    //private AsyncOperation async;

    // Use this for initialization
    void Start () {
        //StartCoroutine("LoadLevel");
    }

    public void StartMenu()
    {
        Application.LoadLevel(0);
        //async.allowSceneActivation = true;
    }

    //IEnumerator LoadLevel()
    //{
    //    print("Loading started");
    //    async = Application.LoadLevelAsync(0);
    //    async.allowSceneActivation = false;
    //    print("Loading completed");
    //    yield return async;
    //}
}

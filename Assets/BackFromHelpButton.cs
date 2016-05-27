using UnityEngine;
using System.Collections;

public class BackFromHelpButton : MonoBehaviour {

    public Canvas Menu;
    public Canvas Help;
    private AsyncOperation async;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Pressed() {
        Help.gameObject.SetActive(false);
        Menu.gameObject.SetActive(true);
    }
}

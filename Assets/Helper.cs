using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Helper : MonoBehaviour {

    public Canvas Menu;
    public Canvas Help;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Pressed() {
        Menu.gameObject.SetActive(false);
        Help.gameObject.SetActive(true);
    }
}

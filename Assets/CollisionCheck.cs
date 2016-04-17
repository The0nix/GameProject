using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollisionCheck : MonoBehaviour {

    public bool isOn = true;
    public Image GameOverBG;
    public Text GameOverText;
    public Button GameOverButton;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obst"))
        {
            GameOverBG.gameObject.SetActive(true);
            GameOverText.gameObject.SetActive(true);
            GameOverButton.gameObject.SetActive(true);
            isOn = false;
        }
    }
}

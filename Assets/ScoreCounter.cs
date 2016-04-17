using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

    public GameObject Collider;
    public Text GameOverText;

    public int counter;
    public Text CountText;
	// Use this for initialization
	void Start () {
        Collider = GameObject.FindGameObjectWithTag("Collider");
        counter = 0;
	}

    // Update is called once per frame
    void Update()
    {
        if (Collider.GetComponent<CollisionCheck>().isOn)
        {
            ++counter;
            GameOverText.text = "GameOver\n\nYour score: " + counter;
            CountText.text = "Score: " + counter;
        }
    }
}

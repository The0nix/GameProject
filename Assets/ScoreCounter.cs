using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

    public Text GameOverText;

    public static float counter;
    public Text CountText;

    bool isRed;

	void Start () {
        isRed = false;
        CountText.color = Color.white;
        counter = 0;
	}

    // Update is called once per frame
    void Update()
    {
        if (!isRed && (int)(counter * 10) > GameSave.current.HighScore) {
            CountText.color = Color.red;
        }
        if (CollisionCheck.ColliderIsOn)
        {
            counter += Time.deltaTime;  
            CountText.text = "Score: " + (int)(counter * 10);
        }
    }
}

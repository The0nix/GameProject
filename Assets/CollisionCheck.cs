using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollisionCheck : MonoBehaviour {

    public static bool ColliderIsOn = true;
    public Image FlashPanel;
    public Text GameOverText;
    public Canvas GameOverCanvas;
    public AudioSource BoomSound;
    public AudioSource PlayOST;
    public AudioSource PauseOST;
    // Use this for initialization
    void Start () {
        ColliderIsOn = true;
    }
	
	// Update is called once per frame
	void Update () {

    }

    private const float DelayBeforeFlash = 0.1f;
    private const float DelayAfterFlash = 0.2f;

    void OnTriggerEnter(Collider other)
    {
        if (ColliderIsOn && other.gameObject.CompareTag("obst"))
        {
            FlashPanel.CrossFadeAlpha(255, DelayBeforeFlash, false);
            ColliderIsOn = false;
            PlayOST.Stop();
            BoomSound.Play();
            PauseOST.time = (Random.Range(0, PauseOST.clip.length / 2) + PauseOST.clip.length / 15);
            PauseOST.Play();
            StartCoroutine("MenuAndFade");
        }
    }

    IEnumerator MenuAndFade()
    {
        yield return new WaitForSeconds(DelayBeforeFlash);
        bool isRecord = (int)(ScoreCounter.counter * 10) > GameSave.current.HighScore;
        if (isRecord) {
                GameSave.current.HighScore = (int)(ScoreCounter.counter * 10);
        }
        GameOverText.text = "GameOver\n\nHigh score: " + GameSave.current.HighScore + "\n\nYour score: " + (int)(ScoreCounter.counter * 10); ;
        GameOverCanvas.gameObject.SetActive(true);
        FlashPanel.CrossFadeAlpha(1, DelayAfterFlash, false);
        if(isRecord) {
            SaveLoad.Save();
        }

    }
}

using UnityEngine;
using System.Collections;

[System.Serializable]
public class GameSave {

    public static GameSave current;
    public long HighScore;

    public GameSave() {
        HighScore = 0;
    }

    public GameSave(long NewHighScore) {
        HighScore = NewHighScore;
    }
}

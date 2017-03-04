using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : Singleton<ScoreManager> {

	[SerializeField]
    private Text scoreText;

    private int score;

    public void IncrementScore ()
    {
        score++;
        scoreText.text = score.ToString ();
    }

}

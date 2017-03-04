using UnityEngine;

public class GameManager : Singleton<GameManager> {

    private bool isGameOver;

	public void GameOver ()
    {
        if (isGameOver)
        {
            return;
        }

        isGameOver = true;
        Debug.Log ("Game Over");
    }

}

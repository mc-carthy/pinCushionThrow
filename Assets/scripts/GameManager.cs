using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager> {

    [SerializeField]
    private Animator animator;

    private Rotator rotator;
    private Spawner spawner;

    private bool isGameOver;

    protected override void Awake ()
    {
        base.Awake ();
        rotator = FindObjectOfType<Rotator> ();
        spawner = FindObjectOfType<Spawner> ();
    }

	public void GameOver ()
    {
        if (isGameOver)
        {
            return;
        }

        isGameOver = true;
        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger ("endGame");
    }

    public void RestartLevel ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex, LoadSceneMode.Single);
    }

}

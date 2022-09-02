using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{

    public Controls Controls;
    public GameObject Loss;
    public GameObject Won;
    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public State CurrentState { get; private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Loss;
        Controls.enabled = false;
        Loss.SetActive(true);

    }

    public void OnPlayerReachedFinish()
    {
       if(CurrentState != State.Playing) return;

        CurrentState = State.Won;
        Controls.enabled = false;
        LevelIndex++;
        Won.SetActive(true);
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Loss.SetActive(false);
        Won.SetActive(false);
    }

    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        set
        {
            PlayerPrefs.SetInt(LevelIndexKey, value);
            PlayerPrefs.Save();
        }
    }
    private const string LevelIndexKey = "LevelIndex";

    public int Score
    {
        get => PlayerPrefs.GetInt(ScoreKey, 0);
        set
        {
            PlayerPrefs.SetInt(ScoreKey, value);
            PlayerPrefs.Save();
        }
    }
    private const string ScoreKey = "Score";
}

using UnityEngine;
using UnityEngine.UI;

public class GameText : MonoBehaviour
{
    public Text CurrentLevelText;
    public Text NextLevelText;
    public Text ScoreTextInGame;
    public Text ScoreTextLoss;
    public Text ScoreTextWon;
    public Game Game;

    private void Start()
    {
        CurrentLevelText.text = (Game.LevelIndex + 1).ToString();
        NextLevelText.text = (Game.LevelIndex + 2).ToString();
    }
    private void Update()
    {
        ScoreTextInGame.text = "Score " + Game.Score.ToString();
        ScoreTextLoss.text = "Score " + Game.Score.ToString();
        ScoreTextWon.text = "Score " + Game.Score.ToString();
    }

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private int score;
    public Text ScoreText;

    void Start()
    {
        score = 0;
        UpdateScore(0);
    }

    public void UpdateScore(int value)
    {
        score += value;
        ScoreText.text = "Score: " + score;
    }

}

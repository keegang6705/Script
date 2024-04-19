//code type : 2D,3D
//code version : 1.0
//last working : unity2022.3.25f

using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public Text scoreText;

    void Start()
    {
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
    }

    public void ScoreUpdate(int Score)
    {
        score += Score;

        UpdateScoreText();

    }
        public void ScoreSet(int Score)
    {
        score = Score;

        UpdateScoreText();

    }

}

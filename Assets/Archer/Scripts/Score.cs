using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    int myScore = 10;
    void update ()
    {
        scoreText.text = myScore.ToString();
    }
    public void AddScore(int score)
    {
        myScore = myScore + score;
    }
}
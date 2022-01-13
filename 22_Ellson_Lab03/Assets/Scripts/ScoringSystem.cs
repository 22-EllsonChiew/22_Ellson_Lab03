using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public static ScoringSystem instance;


    //Score system
    public Text scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + "Score: ";
    }

    public void AddPoint()
    {
        score += 10;
        scoreText.text = score.ToString() + "Score: ";
    }
}

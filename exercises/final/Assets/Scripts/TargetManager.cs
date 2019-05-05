using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetManager : MonoBehaviour
{
    public Text scoreText;
    public Text winText;
    private int score;

    private void Start()
    {
        score = 0;
        SetScoreText();
        winText.text = "";
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
            SetScoreText();
        }
    }
    void SetScoreText()
    {
        scoreText.text = "Score:" + score.ToString();
        if (score >= 1)
        {
            winText.text = "You Win";
        }
    }
}


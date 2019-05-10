using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    public Text scoretext;
    public Text winText;
    private int score;

	// Use this for initialization
	void Start () {

        score = 0;
        scoretext.text = score.ToString();
        winText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
		

	}
    public void incrementscore (){
        score = score +1;
        scoretext.text = score.ToString();
        if (score >= 1)
        {
            winText.text = "You Win!!!";
        }
    }
}

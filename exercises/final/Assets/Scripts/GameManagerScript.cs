using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    public Text scoretext;
    private int score;

	// Use this for initialization
	void Start () {

        score = 0;
        scoretext.text = score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		

	}
    public void incrementscore (){
        score = score +1;
        scoretext.text = score.ToString();
    }
}

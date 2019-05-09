using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetManager : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
            GameObject gmobj = GameObject.Find("GameManager");
            GameManagerScript gm = gmobj.GetComponent<GameManagerScript>();
            gm.incrementscore();
        }        
    }
}


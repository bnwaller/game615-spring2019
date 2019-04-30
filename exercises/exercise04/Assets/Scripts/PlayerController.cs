using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int count;
    public Text countText;
    public Text winText;

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(0, 0, .05f);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0, 0, -.05f);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -5f, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 5f, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 20)
        {
            winText.text = "You Win!";
        }

    }
}

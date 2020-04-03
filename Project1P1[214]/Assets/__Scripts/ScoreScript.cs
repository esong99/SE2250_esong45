using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;           //Initialzing the initial score to a value of 0
    private TextMeshProUGUI scoreText;          //Declaring a varibale for the Text UI element.

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();        //Getting the TextMeshPro UI element on start of the game.
        scoreValue = 0;
    }
    void Update()
    {
        scoreText.text = "Score:" + scoreValue;     //Updating the score value's text field with the score variable.
    }
}

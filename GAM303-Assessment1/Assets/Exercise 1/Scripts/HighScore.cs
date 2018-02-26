using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public static int score = 1000;
    public GameObject HighScoreObject;
    public Text highScoreText;
	void Awake () // Use this for initialization
    {
        if (PlayerPrefs.HasKey("ApplePickerHighScore")) // If the ApplePickerHighScore already exists, read it
        {
            score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", score); // Assign the high score to ApplePickerHighScore
	}
	void Update () // Update is called once per frame
    {
        highScoreText.text = "High Score: " + score;
        if (score>PlayerPrefs.GetInt("ApplePickerHighScore")) // Update ApplePickerHighScore in PlayerPrefs if necessary
        {
            PlayerPrefs.SetInt("ApplePcikerHgihScore", score);
        }
	}
}

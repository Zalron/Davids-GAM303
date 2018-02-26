using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Waypointholder : MonoBehaviour 
{
	public static float timer;
	public static float score;
	public Text scoreText;
	public void Updatescore()
	{
		score += 100;
		scoreText.text = score.ToString ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HardStartButton : MonoBehaviour 
{
	public void PlayHard()
	{
		SceneManager.LoadScene("_Scene_1");
	}
}

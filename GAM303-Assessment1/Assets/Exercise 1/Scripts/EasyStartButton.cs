﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EasyStartButton : MonoBehaviour 
{
	public void PlayEasy()
	{
		SceneManager.LoadScene("_Scene_0");
	}
}

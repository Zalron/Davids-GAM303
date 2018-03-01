using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EasyStartButton : MonoBehaviour 
{


	void Start () // Use this for initialization
	{
		
	}
	void Update () // Update is called once per frame
	{
		
	}
	void OnClick()
	{
		SceneManager.LoadScene("_Scene_0");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour 
{
	public Text countDown;
	public Text keyboardAdd;
	public float Timer = 20;
	public float Num1 = 1;
	public float Num2 = 2;
	public float Num3 = 3;
	public float Num4 = 4;
	public float Num5 = 5;
	public float Num6 = 6;
	public float Num7 = 7;
	public float Num8 = 8;
	public float Num9 = 9;
	public float Num0 = 0;
	void Start () // Use this for initialization
	{
		countDown.text = Timer.ToString();
		//keyboardAdd.text = Num1.ToString();
	}
	void Update () // Update is called once per frame
	{
		//keyboardAdd Keys
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			keyboardAdd.text += Num1.ToString();
		}
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			keyboardAdd.text += Num2.ToString();
		}
		if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			keyboardAdd.text += Num3.ToString();
		}
		if(Input.GetKeyDown(KeyCode.Alpha4))
		{
			keyboardAdd.text += Num4.ToString();
		}
		if(Input.GetKeyDown(KeyCode.Alpha5))
		{
			keyboardAdd.text += Num5.ToString();
		}
		if(Input.GetKeyDown(KeyCode.Alpha6))
		{
			keyboardAdd.text += Num6.ToString();
		}
		if(Input.GetKeyDown(KeyCode.Alpha7))
		{
			keyboardAdd.text += Num7.ToString();
		}
		if(Input.GetKeyDown(KeyCode.Alpha8))
		{
			keyboardAdd.text += Num8.ToString();
		}
		if(Input.GetKeyDown(KeyCode.Alpha9))
		{
			keyboardAdd.text += Num9.ToString();
		}
		if (Input.GetKeyDown (KeyCode.Alpha0)) 
		{
			keyboardAdd.text += Num0.ToString ();
		}
		// countDown functionality 
		Timer -= Time.deltaTime;
		countDown.text = Timer.ToString ("##.#");
	}
}
